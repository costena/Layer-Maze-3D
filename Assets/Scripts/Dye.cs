using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dye : MonoBehaviour
{
    public int dyeNumber;
    public GameObject dyeEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<Bag>().color=dyeNumber;
            GameObject effect = Instantiate(dyeEffect);
            effect.transform.position = transform.position;
            Renderer renderer = effect.GetComponent<ParticleSystem>().GetComponent<Renderer>();
            switch (dyeNumber)
            {
                case 1:
                    renderer.material.color = new Color(1, 1, 0);
                    break;
                case 2:
                    renderer.material.color = Color.blue;
                    break;
                case 3:
                    renderer.material.color = Color.green;
                    break;
                case 4:
                    renderer.material.color = new Color(1, .5f, .5f);
                    break;
                case 5:
                    renderer.material.color = Color.yellow;
                    break;
                default:
                    break;
            }
            
            Destroy(effect, 1.2f);
        }
    }
}
