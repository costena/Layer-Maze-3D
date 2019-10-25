using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunnel : MonoBehaviour
{
    public GameObject child1;
    public GameObject child2;
    public int color = 2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.GetComponent<Bag>().color == color)
            {
                child1.GetComponentInChildren<BoxCollider>().enabled = false;
                child2.GetComponentInChildren<BoxCollider>().enabled = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        child1.GetComponentInChildren<BoxCollider>().enabled = true;
        child2.GetComponentInChildren<BoxCollider>().enabled = true;
    }
}
