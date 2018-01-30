using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAuto : MonoBehaviour
{
    public GameObject player;
    public Vector2 velocity;
    public float speed;





    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.rigidbody.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
        Debug.Log("bouummmm");
    }


  

}


