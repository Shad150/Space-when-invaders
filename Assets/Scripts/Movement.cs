using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    int health;

    public float speed;

    private Rigidbody2D rigidBody2D;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        health = 150;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction = new Vector2(Input.GetAxis("HorizontalP1"), 0);

        // TranslateMovement();

        VelocityMomento();

        //AddingForceMovement();

        /*
         * Es lo mismo que lo anterior pero más largo.
        float x = Input.GetAxis("Horizontal");
        float y = 0;
        */

        if (health <= 0)
        {
            gameObject.SetActive(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Kill"))
        {
            gameObject.SetActive(false);
        }
        else if (collision.CompareTag("PVP"))
        {
            health -= 1;
        }
    }

    void MovePosition()
    {
        rigidBody2D.MovePosition((Vector2)transform.position + speed * direction * Time.fixedDeltaTime);
    }

    void VelocityMomento()
    {
        rigidBody2D.velocity= direction * speed;
    }

    void AddingForceMovement()
    {
        rigidBody2D.AddForce(direction * speed);
    }
}
