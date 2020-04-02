using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class P2Bullet : MonoBehaviour
{

    private Rigidbody2D rigidBody2D;

    public float speed = 10;


    void Start()
    {
        rigidBody2D = gameObject.GetComponent<Rigidbody2D>();

        rigidBody2D.velocity = Vector2.down * speed;

        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Shot"))
        {
            Destroy(gameObject);
        }
    }

}
