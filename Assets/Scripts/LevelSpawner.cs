using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class LevelSpawner : MonoBehaviour
{
    public GameObject wall;
    public GameObject start;
    public GameObject exit;
    public GameObject glass;
    public GameObject bonus;
    public GameObject[] keys;
    public GameObject[] locks;
    public GameObject[] dyes;
    public GameObject tunnel;
    public GameObject lever;
    public GameObject train;
    public GameObject portal;
    public GameObject switchs;
    public RenderTexture[] portalImgs;
    public Material[] portalMats;

    private Transform[] portalRegister = new Transform[5];
    private int portalNum;

    public Material[] materials;

    public Text levelText;
    public Transform player;
    public int levelNumber = 1;

    public static bool leverIsOn = false;
    //AI
    public Block[,,] level;

    private List<GameObject> blocks = new List<GameObject>();

    private void Awake()
    {
        levelText.text = "Level_" + levelNumber;
        GameObject currentBlock;
        level = Level.GetLevel(levelNumber);
        for (int x = 0; x < 15; x++)
            for (int y = 0; y < 15; y++)
                for (int z = 0; z < 15; z++)
                {
                    if (level[x, y, z].type == BlockType.Wall)
                    {
                        currentBlock = Instantiate(wall);
                        blocks.Add(currentBlock);
                        currentBlock.transform.position = new Vector3(x, y, z);
                    }
                    else if (level[x, y, z].type == BlockType.Start)
                    {
                        currentBlock = Instantiate(start);
                        blocks.Add(currentBlock);
                        currentBlock.transform.position = new Vector3(x, y, z);
                        player.position = new Vector3(x, y, z);
                    }
                    else if (level[x, y, z].type == BlockType.Exit)
                    {
                        currentBlock = Instantiate(exit);
                        blocks.Add(currentBlock);
                        currentBlock.transform.position = new Vector3(x, y, z);
                    }
                    else if (level[x, y, z].type == BlockType.Glass)
                    {
                        currentBlock = Instantiate(glass);
                        blocks.Add(currentBlock);
                        currentBlock.transform.position = new Vector3(x, y, z);
                    }
                    else if (level[x, y, z].type == BlockType.Key)
                    {
                        currentBlock = Instantiate(keys[level[x, y, z].index - 1]);
                        blocks.Add(currentBlock);
                        currentBlock.transform.position = new Vector3(x, y, z);
                    }
                    else if (level[x, y, z].type == BlockType.Lock)
                    {
                        currentBlock = Instantiate(locks[level[x, y, z].index - 1]);
                        blocks.Add(currentBlock);
                        currentBlock.transform.position = new Vector3(x, y, z);
                    }
                    else if (level[x, y, z].type == BlockType.Bonus)
                    {
                        currentBlock = Instantiate(bonus);
                        blocks.Add(currentBlock);
                        currentBlock.transform.position = new Vector3(x, y, z);
                        player.GetComponent<Bag>().target++;
                    }
                    else if (level[x, y, z].type == BlockType.Dye)
                    {
                        currentBlock = Instantiate(dyes[level[x, y, z].index - 1]);
                        blocks.Add(currentBlock);
                        currentBlock.transform.position = new Vector3(x, y, z);
                    }
                    else if (level[x, y, z].type == BlockType.Tunnel)
                    {
                        currentBlock = Instantiate(tunnel);
                        blocks.Add(currentBlock);
                        currentBlock.transform.position = new Vector3(x, y, z);
                        if (level[x, y, z].dir) currentBlock.transform.Rotate(0, 90, 0);
                        Tunnel[] t = currentBlock.GetComponentsInChildren<Tunnel>();
                        t[0].color = level[x, y, z].index;
                        t[1].color = level[x, y, z].index2;
                        currentBlock.GetComponentsInChildren<MeshRenderer>()[1].material = Instantiate(materials[level[x, y, z].index - 1]);
                        currentBlock.GetComponentsInChildren<MeshRenderer>()[0].material = Instantiate(materials[level[x, y, z].index2 - 1]);
                    }
                    else if (level[x, y, z].type == BlockType.Lever)
                    {
                        currentBlock = Instantiate(lever);
                        blocks.Add(currentBlock);
                        currentBlock.transform.position = new Vector3(x, y, z);
                    }
                    else if (level[x, y, z].type == BlockType.Train)
                    {
                        currentBlock = Instantiate(train);
                        blocks.Add(currentBlock);
                        if (level[x, y, z].index % 2 == 0)
                        {
                            currentBlock.transform.position = new Vector3(x + level[x, y, z].index2 / 2, y, z);
                        }
                        else
                        {
                            currentBlock.transform.position = new Vector3(x, y, z + level[x, y, z].index2 / 2);
                        }
                        currentBlock.GetComponent<Train>().SendCommand(level[x, y, z].index, level[x, y, z].index2);
                    }
                    else if (level[x, y, z].type == BlockType.Portal)
                    {
                        currentBlock = Instantiate(portal);
                        blocks.Add(currentBlock);
                        currentBlock.transform.position = new Vector3(x, y, z);
                        currentBlock.GetComponentInChildren<Camera>().targetTexture = portalImgs[portalNum];
                        currentBlock.GetComponent<MeshRenderer>().material = portalMats[portalNum];
                        portalNum++;

                        if (portalRegister[level[x, y, z].index] == null)
                        {
                            portalRegister[level[x, y, z].index] = currentBlock.transform;
                        }
                        else
                        {
                            portalRegister[level[x, y, z].index].GetComponent<Portal>().target = currentBlock.transform;
                            currentBlock.GetComponent<Portal>().target = portalRegister[level[x, y, z].index].transform;
                        }
                    }
                    else if (level[x, y, z].type == BlockType.Switch)
                    {
                        currentBlock = Instantiate(switchs);
                        blocks.Add(currentBlock);
                        if (level[x, y, z].index % 2 == 0)
                        {
                            currentBlock.transform.position = new Vector3(x + .5f, y, z);
                        }
                        else
                        {
                            currentBlock.transform.position = new Vector3(x, y, z + .5f);
                        }
                        currentBlock.transform.Rotate(0, level[x, y, z].index * 90, 0);
                    }
                }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Comma)) Prevnew();
        if (Input.GetKey(KeyCode.Period)) Nextnew();
    }

    public void Renew()
    {
        foreach(GameObject block in blocks)
        {
            Destroy(block, Random.Range(0, 3f));
        }
        blocks.Clear();
        levelNumber++;
        Invoke("Awake", 3);
        Bag bag = player.GetComponent<Bag>();
        bag.keys.Clear();
        bag.score = 0;
        bag.target = 0;
        bag.color = 2;
    }
    public void Nextnew()
    {
        foreach (GameObject block in blocks)
        {
            Destroy(block);
        }
        blocks.Clear();
        levelNumber++;
        Bag bag = player.GetComponent<Bag>();
        bag.keys.Clear();
        bag.score = 0;
        bag.target = 0;
        bag.color = 2;
        Awake();
    }

    public void Prevnew()
    {
        foreach (GameObject block in blocks)
        {
            Destroy(block);
        }
        blocks.Clear();
        levelNumber--;
        Bag bag = player.GetComponent<Bag>();
        bag.keys.Clear();
        bag.score = 0;
        bag.target = 0;
        bag.color = 2;
        Awake();
    }
}
