using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRotate : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(new Vector3(15, 20, 25) * Time.deltaTime * 20);
    }
}
