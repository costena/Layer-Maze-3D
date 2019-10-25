using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour
{
    public float speed = 1;
    public float keySpeed = 1;
    public float rotateSpeed = 1;

    public Transform player;

    private Rigidbody playerRigidbody;
    private float angleX = 0;
    private float angleY = 0;

    private void Start()
    {
        playerRigidbody = player.gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        angleX -= Input.GetAxis("Mouse Y") * rotateSpeed;
        if (angleX > 60) angleX = 60;
        else if (angleX < -60) angleX = -60;
        angleY += Input.GetAxis("Mouse X") * rotateSpeed;
        transform.rotation = Quaternion.Euler(angleX, angleY, 0);
        playerRigidbody.velocity = Input.GetAxis("Vertical") * new Vector3(transform.forward.x,0,transform.forward.z).normalized * speed * Time.deltaTime
            + new Vector3(0, (Input.GetKey(KeyCode.Space) ? 1 : 0) - (Input.GetKey(KeyCode.LeftShift) ? 1 : 0), 0) * keySpeed * Time.deltaTime
            + Input.GetAxis("Horizontal") * new Vector3(transform.forward.normalized.z, 0, -transform.forward.normalized.x) * speed * Time.deltaTime;
        //playerRigidbody.velocity = velocityVertical * new Vector3(transform.forward.x, 0, transform.forward.z).normalized * speed * Time.deltaTime +
        //    velocityUpDown * new Vector3(0, 1, 0) * speed * Time.deltaTime +
        //    velocityHorizontal * new Vector3(transform.forward.normalized.z, 0, -transform.forward.normalized.x) * speed * Time.deltaTime;
    }

}
