using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerPurple : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo4"))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }
    }
}
