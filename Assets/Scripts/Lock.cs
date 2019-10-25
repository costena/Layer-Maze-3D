using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public int lockNumber;
    public GameObject explosion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.GetComponent<Bag>().keys.Contains(lockNumber))
            {
                GameObject effect = Instantiate(explosion, transform.position, transform.rotation);
                effect.GetComponent<Renderer>().material = gameObject.GetComponent<MeshRenderer>().materials[0];
                Destroy(effect, 1.2f);
                Destroy(gameObject);
            }
        }
    }
}
