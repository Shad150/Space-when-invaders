using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class EnemyMovement : MonoBehaviour
{

    int health;
    public bool eDeath;

    private Rigidbody2D rigidBody2D;

    bool direction;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        health = 2000;
        eDeath = false;
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody2D = gameObject.GetComponent<Rigidbody2D>();

        if (direction == false)
        {
            rigidBody2D.velocity = Vector2.right * speed;
        }
        else
        {
        rigidBody2D.velocity = Vector2.left * speed;
        }

        if (health <= 0)
        {
            eDeath = true;
            gameObject.SetActive(false);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.otherCollider)
        {
            if (direction == false)
            {
                direction = true;
            }
            else
            {
                direction = false;
            }
            
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Shot"))
        {
            health -= 1;
        }
    }

}
