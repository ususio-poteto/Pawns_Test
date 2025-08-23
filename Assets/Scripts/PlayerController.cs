using System;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float catSpeed = 0;
    public Queue<Vector2> positionHistory = new Queue<Vector2>();
    [SerializeField] private GameObject partner;
    private GirlController girlController;

    private void Awake()
    {
        positionHistory.Enqueue(new Vector2(transform.position.x, transform.position.y));
        girlController = partner.GetComponent<GirlController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.position += new Vector3(catSpeed, 0, 0);
            positionHistory.Enqueue(transform.position);
            girlController.FollowPosition(positionHistory.Dequeue());
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-catSpeed, 0, 0);
            positionHistory.Enqueue(transform.position);
            girlController.FollowPosition(positionHistory.Dequeue());
        }
    }
}
