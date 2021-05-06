using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerOrange : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo2"))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }
    }
}
