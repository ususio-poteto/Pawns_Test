using System;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float normalSpeed = 0;
    [SerializeField] private float dashSpeed = 0;
    private float currentSpeed = 0;
    [SerializeField] private float jumpForce = 0;
    private Rigidbody2D rb;
    [SerializeField] private bool isGrounded;

    private string distance = "right";
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        currentSpeed = normalSpeed;
    }

    // Update is called once per frame
    void Update()
    {
       //横移動
       float move =  Input.GetAxis("Horizontal");
       rb.linearVelocity = new Vector2(move * currentSpeed, rb.linearVelocity.y);

       if (move > 0) distance = "right";
       else if (move < 0) distance = "left";
       
       if(distance == "right") transform.rotation = Quaternion.Euler(0, 0, 0);
       else if(distance == "left") transform.rotation = Quaternion.Euler(0, 180, 0);
       
       //ジャンプ
       if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
       {
           rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
       }

       if (Input.GetKey(KeyCode.LeftShift)) currentSpeed = dashSpeed;
       else currentSpeed = normalSpeed;
       
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        isGrounded = false; 
    }
}
