using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveing : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpforce;
    private float moveInput;

    private bool facingRight = true;

    private bool ifGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGrounded;

    private int jumpo;



    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ifGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGrounded);



        moveInput = Input.GetAxis("Horizontal");
        Debug.Log(moveInput);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if(facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

 

    private void Update()
    {
        if(ifGrounded == true)
        {
            jumpo = 1;
        }


        if(Input.GetKeyDown(KeyCode.W) && jumpo > 0)
        {
            rb.velocity = Vector2.up * jumpforce;
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
