using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public Transform rod;
    public Light redLight;
    public Light greenLight;
    public MeshRenderer redMesh;
    public MeshRenderer greenMesh;
    public Material redDark;
    public Material redBright;
    public Material greenDark;
    public Material greenBright;


    private void Update()
    {
        float angle = rod.rotation.eulerAngles.x;
        if (LevelSpawner.leverIsOn)
        {
            if (angle > 330 || angle >= 0 && angle <= 180)
                rod.Rotate(-300 * Time.deltaTime, 0, 0);
        }
        else
        {
            if (angle < 30 || angle < 360 && angle >= 180) 
                rod.Rotate(300 * Time.deltaTime, 0, 0);
        }
        if (angle > 180)
        {
            redLight.enabled = false;
            greenLight.enabled = true;
            redMesh.material = redDark;
            greenMesh.material = greenBright;
        }
        else
        {
            redLight.enabled = true;
            greenLight.enabled = false;
            redMesh.material = redBright;
            greenMesh.material = greenDark;
        }
    }

    private void OnMouseDown()
    {
        LevelSpawner.leverIsOn = !LevelSpawner.leverIsOn;
    }
}
