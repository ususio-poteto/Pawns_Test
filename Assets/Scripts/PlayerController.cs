using System;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0;
    [SerializeField] private float jumpForce = 0;
    private Rigidbody2D rb;
    [SerializeField] private bool isGrounded;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       //横移動
       float move =  Input.GetAxis("Horizontal");
       rb.linearVelocity = new Vector2(move * moveSpeed, rb.linearVelocity.y);
       
       //ジャンプ
       if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
       {
           rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
       }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        isGrounded = false; 
    }
}
