using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(transform.localRotation.eulerAngles.x);
        if (transform.localRotation.eulerAngles.x < 270 && transform.localRotation.eulerAngles.x > 0)
        {
            if (transform.localRotation.eulerAngles.x > 135)
            {
                transform.localRotation = Quaternion.Euler(270, 0, 0);
            }
            else
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }
}
