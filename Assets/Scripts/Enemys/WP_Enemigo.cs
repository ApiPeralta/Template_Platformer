using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WP_Enemigo : MonoBehaviour
{
    float speed = 3.0f;
    private bool yen2;
    public Transform target;
    public Transform target2;
    void Start()
    {
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if(yen2 == false)
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        else
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WayPoint"))
        {          
            transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
            transform.Translate(new Vector3(0, - speed * Time.deltaTime, 0));
            yen2 = false;
        }
        if (other.CompareTag("WayPoint2"))
        {
            transform.LookAt(new Vector3(target2.position.x, transform.position.y, target.position.z));
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
            yen2 = true;
        }
    }
}
