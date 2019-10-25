using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform target;
    public Transform render;
    public bool transfer = true;

    private void Start()
    {
        try { render.position = target.position; }catch(Exception e) { }
    }

    private void Update()
    {
        try
        {
            render.rotation = Camera.main.transform.rotation;
            if (Mathf.Abs(Camera.main.transform.position.x - transform.position.x) > Mathf.Abs(Camera.main.transform.position.z - transform.position.z))
            {
                render.position = Camera.main.transform.position - transform.position + target.position + new Vector3(Mathf.Sign(transform.position.x - Camera.main.transform.position.x), 0, 0);
            }
            else
            {
                render.position = Camera.main.transform.position - transform.position + target.position + new Vector3(0, 0, Mathf.Sign(transform.position.z - Camera.main.transform.position.z));
            }
            render.GetComponent<Camera>().nearClipPlane = (render.position - target.position).magnitude;
        }catch(Exception e) { }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (transfer)
            {
                target.GetComponent<Portal>().transfer = false;
                if (Mathf.Abs(other.transform.position.x - transform.position.x) > Mathf.Abs(other.transform.position.z - transform.position.z))
                {
                    other.transform.position = target.position + other.transform.position - transform.position + new Vector3(Mathf.Sign(transform.position.x - Camera.main.transform.position.x), 0, 0);
                }
                else
                {
                    other.transform.position = Camera.main.transform.position - transform.position + target.position + new Vector3(0, 0, Mathf.Sign(transform.position.z - Camera.main.transform.position.z));
                }
                //other.transform.position = target.position + other.transform.position - transform.position;
            }
            else
            {
                transfer = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<MeshRenderer>().enabled = true;
    }
}
