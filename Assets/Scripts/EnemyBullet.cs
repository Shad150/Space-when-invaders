using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class EnemyBullet : MonoBehaviour
{

    private Rigidbody2D rigidBody2D;

    public float speed = 10;


    void Start()
    {
        rigidBody2D = gameObject.GetComponent<Rigidbody2D>();

        rigidBody2D.velocity = Vector2.down * speed;

        Destroy(gameObject, 2f);
    }

}
