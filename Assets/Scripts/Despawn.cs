using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public GameObject car;
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision with " + col.gameObject);
      if(col.gameObject.name == "Car")
        {
            Destroy(car);
        }
    }
}
