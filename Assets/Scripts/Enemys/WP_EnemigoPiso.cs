using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WP_EnemigoPiso : MonoBehaviour
{
    float speed = 3.0f;
    private bool yen2;
    //public Transform target;
    //public Transform target2;
    void Start()
    {

    }
    void Update()
    {
        //transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WayPoint"))
        {
            speed = 3.0f;
        }
        if (other.CompareTag("WayPoint2"))
        {
            speed = -3.0f;
        }
    }
}
