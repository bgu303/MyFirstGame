using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{
    public float movementSpeed = 3.0f;
    private Rigidbody2D rigidBody;
    private bool dirRight = true;
    float minX;
    float maxX;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        transform.localPosition = new Vector3(0, 0.13f, 0);
        minX = transform.localPosition.x - 0.066f;
        maxX = transform.localPosition.x + 0.066f;
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

        if (transform.localPosition.x >= maxX)
        {
            dirRight = false;
        }

        if (transform.localPosition.x <= minX)
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
