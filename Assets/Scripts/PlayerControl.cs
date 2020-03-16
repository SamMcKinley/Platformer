﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Transform tf;
    private SpriteRenderer sr;
    
    public float speed = 5.0f;
    public float jumpForce = 10.0f;
    public Transform GroundPoint;
    public bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal") * speed;
        rb2d.velocity = new Vector2(xMovement, rb2d.velocity.y);
        sr.flipX = rb2d.velocity.x < 0;
        //Detect if player is on the ground
        bool isGrounded = false;
        RaycastHit2D hitInfo = Physics2D.Raycast(GroundPoint.position, Vector2.down, 0.1f);
        if (hitInfo.collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        //jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb2d.AddForce(Vector2.up * jumpForce);
            Debug.Log("Jump");
        }
        rb2d.AddForce(Vector2.up * jumpForce);
    }
}
