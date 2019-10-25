using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetToExit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.GetComponent<Bag>().score == other.GetComponent<Bag>().target)
            {
                other.GetComponent<Bag>().score = 0;
                other.GetComponent<Bag>().target = 0;
                other.GetComponent<Win>().GoToNextLevel();
                Destroy(this);
            }
            else
            {
                other.GetComponent<Win>().ShowWarning();
            }
        }
    }
}
