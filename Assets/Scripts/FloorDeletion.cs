using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDeletion : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        if (transform.position.x < ScreenBounds.getScreenBounds().x - 30) {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Police") || other.gameObject.CompareTag("Floor")) {
            Physics2D.IgnoreCollision(other.collider, other.otherCollider);
        }
    }
}
