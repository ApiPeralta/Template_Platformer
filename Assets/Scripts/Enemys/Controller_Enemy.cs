using UnityEngine;

public class Controller_Enemy : MonoBehaviour
{
    public static float enemyVelocity = 3;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.AddForce(new Vector3(-enemyVelocity, 0, 0), ForceMode.Force);
        //OutOfBounds();
    }
    //public void OutOfBounds()
    //{
    //    if (this.transform.position.x <= -40)
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}
}
