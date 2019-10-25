using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public LevelSpawner level;
    public Bag bag;

    private struct Block{
        public int type;
        public int append;
        public bool detected;
        public Vector4Int father;
    }

    private class Vector4Int
    {
        public int c;
        public int x;
        public int y;
        public int z;

        public Vector4Int Left
        {
            get => new Vector4Int(c, x - 1, y, z);
        }

        public Vector4Int Right
        {
            get => new Vector4Int(c, x + 1, y, z);
        }

        public Vector4Int Ahead
        {
            get => new Vector4Int(c, x, y, z - 1);
        }

        public Vector4Int Back
        {
            get => new Vector4Int(c, x, y, z + 1);
        }

        public Vector4Int(int c, int x,int y,int z)
        {
            this.c = c;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector4Int(int c, Vector3Int v)
        {
            this.c = c;
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
    }

    private Block[,,,] blocks = new Block[6, 15, 15, 15];
    private Vector3Int exitPos;
    private Vector4Int startPos;
    private List<Vector4Int> locks = new List<Vector4Int>();
    private List<Vector4Int> tunnels = new List<Vector4Int>();
    private int apple = 0;

    private Vector3Int[] path;

    public void Start()
    {
        GetComponentInChildren<ViewController>().enabled = false;
        blocks = new Block[6, 15, 15, 15];
        locks = new List<Vector4Int>();
        tunnels = new List<Vector4Int>();
        apple = 0;
        for (int x = 0; x < 15; x++)
            for (int y = 0; y < 15; y++)
                for (int z = 0; z < 15; z++)
                {
                    switch (level.level[x, y, z].type)
                    {
                        case BlockType.Air:
                            for (int c = 0; c < 6; c++)
                                blocks[c, x, y, z].type = 0;
                            break;
                        case BlockType.Bonus:
                            for (int c = 0; c < 6; c++)
                                blocks[c, x, y, z].type = -4;
                            break;
                        case BlockType.Dye:
                            for (int c = 0; c < 6; c++)
                            {
                                blocks[c, x, y, z].type = -5;
                                blocks[c, x, y, z].append = level.level[x, y, z].index;
                            }
                            break;
                        case BlockType.Exit:
                            if (bag.target == 0)
                                for (int c = 0; c < 6; c++)
                                    blocks[c, x, y, z].type = -1;
                            else
                                for (int c = 0; c < 6; c++)
                                    blocks[c, x, y, z].type = 0;
                            exitPos = new Vector3Int(x, y, z);
                            break;
                        case BlockType.Glass:
                            for (int c = 0; c < 6; c++)
                                blocks[c, x, y, z].type = 1;
                            break;
                        case BlockType.Key:
                            for (int c = 0; c < 6; c++)
                            {
                                blocks[c, x, y, z].type = -2;
                                blocks[c,x,y,z].append = level.level[x, y, z].index;
                            }
                            break;
                        case BlockType.Lever:
                            for (int c = 0; c < 6; c++)
                                blocks[c, x, y, z].type = 0;
                            break;
                        case BlockType.Lock:
                            for (int c = 0; c < 6; c++)
                            {
                                blocks[c, x, y, z].type = 2;
                                blocks[c, x, y, z].append = level.level[x, y, z].index;
                                locks.Add(new Vector4Int(c, x, y, z));
                            }
                            break;
                        case BlockType.Portal:
                            for (int c = 0; c < 6; c++)
                                blocks[c, x, y, z].type = 1;
                            break;
                        case BlockType.Start:
                            for (int c = 0; c < 6; c++)
                                blocks[c, x, y, z].type = 0;
                            startPos = new Vector4Int(bag.color, x, y, z);
                            break;
                        case BlockType.Switch:
                            for (int c = 0; c < 6; c++)
                                blocks[c, x, y, z].type = 0;
                            break;
                        case BlockType.Train:
                            for (int c = 0; c < 6; c++)
                                blocks[c, x, y, z].type = 0;
                            break;
                        case BlockType.Tunnel:
                            for (int c = 0; c < 6; c++)
                                blocks[c, x, y, z].type = 1;
                            blocks[level.level[x, y, z].index, x, y, z].type = 3;
                            blocks[level.level[x, y, z].index2, x, y, z].type = -3;
                            break;
                        case BlockType.Wall:
                            for (int c = 0; c < 6; c++)
                                blocks[c, x, y, z].type = 1;
                            break;
                    }
                }
        path = GetWay();
        target = 0;
        levelNumber = level.levelNumber;
    }

    int target = 0;
    int levelNumber;

    private void Update()
    {
        try
        {
            if (path.Length > target)
            {
                if ((transform.position - path[target]).magnitude < 0.1f)
                {
                    target++;
                }
                transform.Translate((path[target] - transform.position).normalized * Time.deltaTime * 2);
                if (target + 4 < path.Length)
                {
                    float progress = (path[target] - transform.position).magnitude;
                    transform.GetChild(0).LookAt((Vector3)path[target + 1] * 0.25f * progress + (Vector3)path[target + 2] * (0.25f * progress + 0.25f) + (Vector3)path[target + 3] * (0.5f - 0.25f * progress) + (Vector3)path[target + 4] * (0.25f - 0.25f * progress));
                }
            }
        }
        catch { }
        if (level.levelNumber != levelNumber)
        {
            Invoke("Start",4);
            levelNumber = level.levelNumber;
        }
    }

    private Vector3Int[] GetWay()
    {
        List<Vector4Int> result = FindWay(startPos);
        Stack<Vector3Int> r = new Stack<Vector3Int>();
        for(int i = 0; i < result.Count; i++)
        {
            r.Push(new Vector3Int(result[i].x, result[i].y, result[i].z));
        }
        return r.ToArray();
    }

    private List<Vector4Int> FindWay(Vector4Int start)
    {
        List<Vector4Int> result = new List<Vector4Int>();
        List<Vector4Int> result2 = new List<Vector4Int>();
        Queue<Vector4Int> aliveNode = new Queue<Vector4Int>();
        Block block; //for output ways;
        aliveNode.Enqueue(start);
        blocks[start.c, start.x, start.y, start.z].detected = true;
        int loopCount = 0;
        while (loopCount < 10000 && aliveNode.Count > 0)
        {
            Vector4Int branchNode = aliveNode.Dequeue();
            switch (blocks[branchNode.c, branchNode.x, branchNode.y, branchNode.z].type)
            {
                case 0:
                case -3:
                case -5:
                    List<Vector4Int> temp = Scan(branchNode);
                    foreach (Vector4Int r in temp)
                        aliveNode.Enqueue(r);
                    break;
                case -1: //Found Target
                    block = blocks[branchNode.c, branchNode.x, branchNode.y, branchNode.z];
                    Vector4Int recall1 = branchNode;
                    while (block.father != null)
                    {
                        result.Add(new Vector4Int(recall1.c, recall1.x, recall1.y, recall1.z));
                        recall1 = block.father;
                        block = blocks[recall1.c, recall1.x, recall1.y, recall1.z];
                    }
                    result.Add(new Vector4Int(recall1.c, recall1.x, recall1.y, recall1.z));
                    return result;
                case -2: //Found Key
                    //save path
                    block = blocks[branchNode.c, branchNode.x, branchNode.y, branchNode.z];
                    Vector4Int recall = branchNode;
                    while (block.father != null)
                    {
                        result2.Add(new Vector4Int(recall.c, recall.x, recall.y, recall.z));
                        recall = block.father;
                        block = blocks[recall.c, recall.x, recall.y, recall.z];
                    }
                    result2.Add(new Vector4Int(recall.c, recall.x, recall.y, recall.z));
                    aliveNode.Clear(); //reset the nodes;
                    //refresh the maze
                    foreach (Vector4Int lockPos in locks)
                    {
                        if(blocks[lockPos.c,lockPos.x,lockPos.y,lockPos.z].append == blocks[branchNode.c, branchNode.x, branchNode.y, branchNode.z].append)
                        {
                            blocks[lockPos.c, lockPos.x, lockPos.y, lockPos.z].type = 0;
                        }
                    }
                    blocks[branchNode.c, branchNode.x, branchNode.y, branchNode.z].type = 0;
                    blocks[branchNode.c, branchNode.x, branchNode.y, branchNode.z].father = null;
                    for (int x = 0; x < 15; x++)
                        for (int y = 0; y < 15; y++)
                            for (int z = 0; z < 15; z++)
                                for (int c = 0;  c < 6; c++)
                                    blocks[c, x, y, z].detected = false;
                    //add after nodes
                    List<Vector4Int> temp2 = FindWay(branchNode);
                    foreach (Vector4Int v in temp2)
                    {
                        result.Add(v);
                    }
                    foreach (Vector4Int v in result2)
                    {
                        result.Add(v);
                    }
                    break;
                case -4: //Found Apple
                    //save path
                    block = blocks[branchNode.c, branchNode.x, branchNode.y, branchNode.z];
                    Vector4Int recall2 = branchNode;
                    while (block.father != null)
                    {
                        result2.Add(new Vector4Int(recall2.c, recall2.x, recall2.y, recall2.z));
                        recall2 = block.father;
                        block = blocks[recall2.c, recall2.x, recall2.y, recall2.z];
                    }
                    result2.Add(new Vector4Int(recall2.c, recall2.x, recall2.y, recall2.z));
                    aliveNode.Clear(); //reset the nodes;
                    //refresh the maze
                    apple++;
                    if (apple >= bag.target)
                        for (int c = 0; c < 6; c++)
                            blocks[c, exitPos.x, exitPos.y, exitPos.z].type = -1;
                    blocks[branchNode.c, branchNode.x, branchNode.y, branchNode.z].type = 0;
                    blocks[branchNode.c, branchNode.x, branchNode.y, branchNode.z].father = null;
                    for (int x = 0; x < 15; x++)
                        for (int y = 0; y < 15; y++)
                            for (int z = 0; z < 15; z++)
                                for (int c = 0; c < 6; c++)
                                    blocks[c, x, y, z].detected = false;
                    //add after nodes
                    foreach (Vector4Int v in FindWay(branchNode))
                    {
                        result.Add(v);
                    }
                    foreach (Vector4Int v in result2)
                    {
                        result.Add(v);
                    }
                    break;
            }
            loopCount++;
        }
        return result;
    }

    private List<Vector4Int> Scan(Vector4Int test)
    {
        List<Vector4Int> result = new List<Vector4Int>();
        Block block;
        Vector4Int neibor;
        for (int i = 0; i < 6; i++)
        {
            switch (i)
            {
                case 0:
                    if (test.x == 0) continue;
                    block = blocks[test.c, test.x - 1, test.y, test.z];
                    neibor = new Vector4Int(test.c, test.x - 1, test.y, test.z);
                    break;
                case 1:
                    if (test.x == 14) continue;
                    block = blocks[test.c, test.x + 1, test.y, test.z];
                    neibor = new Vector4Int(test.c, test.x + 1, test.y, test.z);
                    break;
                case 2:
                    if (test.z == 0) continue;
                    block = blocks[test.c, test.x, test.y, test.z - 1];
                    neibor = new Vector4Int(test.c, test.x, test.y, test.z - 1);
                    break;
                case 3:
                    if (test.z == 14) continue;
                    block = blocks[test.c, test.x, test.y, test.z + 1];
                    neibor = new Vector4Int(test.c, test.x, test.y, test.z + 1);
                    break;
                case 4:
                    if (test.y == 0) continue;
                    block = blocks[test.c, test.x, test.y - 1, test.z];
                    neibor = new Vector4Int(test.c, test.x, test.y - 1, test.z);
                    break;
                default:
                    if (test.y == 14) continue;
                    block = blocks[test.c, test.x, test.y + 1, test.z];
                    neibor = new Vector4Int(test.c, test.x, test.y + 1, test.z);
                    break;
            }
            if (!block.detected)
            {
                switch (block.type)
                {
                    case 0:
                    case -1:
                    case -2:
                    case -4:
                        result.Add(new Vector4Int(neibor.c, neibor.x, neibor.y, neibor.z));
                        blocks[neibor.c, neibor.x, neibor.y, neibor.z].father = test;
                        break;
                    case 3:
 /*                       if()
                        if (neibor.c)
                        {
                            result.Add(new Vector4Int(neibor.c, neibor.x * 2 - test.x, neibor.y * 2 - test.y, neibor.z * 2 - test.z));
                            blocks[neibor.c, neibor.x * 2 - test.x, neibor.y * 2 - test.y, neibor.z * 2 - test.z].father = test;
                            blocks[neibor.c, neibor.x * 2 - test.x, neibor.y * 2 - test.y, neibor.z * 2 - test.z].detected = true;
                        }
                        break;*/
                    case -5:
                        if (!blocks[block.append, neibor.x, neibor.y, neibor.z].detected)
                        {
                            result.Add(new Vector4Int(block.append, neibor.x, neibor.y, neibor.z));
                            blocks[block.append, neibor.x, neibor.y, neibor.z].father = test;
                            blocks[block.append, neibor.x, neibor.y, neibor.z].detected = true;
                        }
                        break;
                }
                blocks[neibor.c, neibor.x, neibor.y, neibor.z].detected = true;
            }
        }
        return result;
    }
}