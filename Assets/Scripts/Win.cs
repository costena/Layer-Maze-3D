using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject levelSpawner;
    public Animator animator;

    public void GoToNextLevel()
    {
        levelSpawner.GetComponent<LevelSpawner>().Renew();
    }

    public void ShowWarning()
    {
        animator.SetTrigger("PlayWarning");
    }
}
