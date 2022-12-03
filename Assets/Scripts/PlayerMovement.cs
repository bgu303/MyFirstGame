using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    private float Move;
    public float jumpAmount;
    public bool isJumping;
    public GameObject start;
    public GameObject Player;

    private Rigidbody2D rigidBody;
    private BoxCollider2D boxCollider;
    public Animator animator;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        if (PlayerPrefs.HasKey("playerspeed"))
        {
            speed = PlayerPrefs.GetFloat("playerspeed");
        }
        else
        {
            speed = 400;
        }
        if (PlayerPrefs.HasKey("jumpamount"))
        {
            jumpAmount = PlayerPrefs.GetFloat("jumpamount");
        }
        else
        {
            jumpAmount = 10;
        }

        if (Input.GetKeyDown("space") && isJumping == false)
        {
            rigidBody.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetBool("Idle", false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localRotation = Quaternion.Euler(0, -180, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
            animator.SetBool("Idle", true);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }

    void FixedUpdate()
    {
        rigidBody.velocity = new Vector2(speed * Move * Time.fixedDeltaTime, rigidBody.velocity.y);

    }
}
