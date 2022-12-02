using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float movementSpeed;
    private Rigidbody2D rigidBody;
    private float minX = 15.5f;
    private float maxX = 20.8f;
    private bool dirRight = true;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {

        if (dirRight)
        {
            rigidBody.velocity = new Vector2(movementSpeed * Time.fixedDeltaTime, rigidBody.velocity.y);
        }
        else
        {
            rigidBody.velocity = new Vector2(-movementSpeed * Time.fixedDeltaTime, rigidBody.velocity.y);
        }

        if (transform.position.x >= maxX)
        {
            dirRight = false;
        }

        if (transform.position.x <= minX)
        {
            dirRight = true;
        }

    }

    private void OnCollisionEnter2D(Collision2D other) {
            if(other.gameObject.CompareTag("Police")) {
                Physics2D.IgnoreCollision(other.collider, other.otherCollider);
            }
        }

}
