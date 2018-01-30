using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float unitePerSec = 1f;
    public Vector3 newVelocity = Vector3.zero;




    void Start()

    {
        
    }

    void FixedUpdate()

    {
        newVelocity = GetComponent<Rigidbody2D>().velocity;  //position de depart
        float speed = unitePerSec;

      if (Input.GetKey(KeyCode.LeftArrow))

        {
            newVelocity.x = -speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))

        {
            newVelocity.x = speed;
        }

        GetComponent<Rigidbody2D>().velocity = newVelocity;
    }


}
