using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{

    public Rigidbody2D rb;

    public float minSpeed = 8f;
    public float maxSpeed = 12f;

    public float speed = 1.0f;

     void Start()
    {
        Destroy(gameObject, 3f);   
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }
    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
