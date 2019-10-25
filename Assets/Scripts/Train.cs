using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    public Transform body;
    public Transform redHead;
    public Transform greenHead;
    public Light redLight;
    public Light greenLight;
    public MeshRenderer redMaterial;
    public MeshRenderer greenMaterial;
    public Material redDark;
    public Material redBright;
    public Material greenDark;
    public Material greenBright;
    Rigidbody train;
    int direction;

    private void Start()
    {
        train = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (LevelSpawner.leverIsOn)
        {
            redMaterial.material = redDark;
            greenMaterial.material = greenBright;
            redLight.enabled = false;
            greenLight.enabled = true;
        }
        else
        {
            redMaterial.material = redBright;
            greenMaterial.material = greenDark;
            redLight.enabled = true;
            greenLight.enabled = false;
        }
        switch (direction)
        {
            case 0:
                if (LevelSpawner.leverIsOn)
                {
                    train.AddForce(-1, 0, 0);
                }
                else{
                    train.AddForce(1, 0, 0);
                }
                break;
            case 1:
                if (LevelSpawner.leverIsOn)
                {
                    train.AddForce(0, 0, -.8f);
                }
                else
                {
                    train.AddForce(0, 0, .8f);
                }
                break;
            case 2:
                if (LevelSpawner.leverIsOn)
                {
                    train.AddForce(1, 0, 0);
                }
                else
                {
                    train.AddForce(-1, 0, 0);
                }
                break;
            case 3:
                if (LevelSpawner.leverIsOn)
                {
                    train.AddForce(0, 0, .8f);
                }
                else
                {
                    train.AddForce(0, 0, -.8f);
                }
                break;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            train.constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (direction % 2 == 0)
            {
                train.constraints = ~RigidbodyConstraints.FreezePositionX;
            }
            else
            {
                train.constraints = ~RigidbodyConstraints.FreezePositionZ;
            }
        }
    }

    public void SendCommand(int dir,int len)
    {
        direction = dir;
        transform.Rotate(0, 90 * dir, 0);
        body.localScale = new Vector3(.9f, (len - 1f) / 2, .9f);
        switch (dir)
        {
            case 0:
                redHead.position = new Vector3((len - 1f) / 2, 0, 0) + transform.position;
                greenHead.position = new Vector3((1f - len) / 2, 0, 0) + transform.position;
                break;
            case 1:
                redHead.position = new Vector3(0, 0, (len - 1f) / 2) + transform.position;
                greenHead.position = new Vector3(0, 0, (1f - len) / 2) + transform.position;
                break;
            case 2:
                redHead.position = new Vector3((1f - len) / 2, 0, 0) + transform.position;
                greenHead.position = new Vector3((len - 1f) / 2, 0, 0) + transform.position;
                break;
            case 3:
                redHead.position = new Vector3(0, 0, (1f - len) / 2) + transform.position;
                greenHead.position = new Vector3(0, 0, (len - 1f) / 2) + transform.position;
                break;
        }
        if (direction % 2 == 0)
        {
            GetComponent<Rigidbody>().constraints = ~RigidbodyConstraints.FreezePositionX;
        }
        else
        {
            GetComponent<Rigidbody>().constraints = ~RigidbodyConstraints.FreezePositionZ;
        }
        GetComponent<BoxCollider>().size = new Vector3(len, 1, 1);
    }
}
