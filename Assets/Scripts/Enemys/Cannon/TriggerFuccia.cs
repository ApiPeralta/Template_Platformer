using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerFuccia : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo7"))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }
    }
}
