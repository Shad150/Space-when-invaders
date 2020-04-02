using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]     //Obliga a añadir un componente al objeto.

public class Bullet : MonoBehaviour
{

    private Rigidbody2D rigidBody2D;

    public float speed = 10;


    void Start()
    {
        rigidBody2D = gameObject.GetComponent<Rigidbody2D>();

        rigidBody2D.velocity = Vector2.up * speed;

        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player2"))
        {
            Destroy(gameObject);
        }
        else if (collision.CompareTag("PVP"))
        {
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Kill"))
        {
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

}
