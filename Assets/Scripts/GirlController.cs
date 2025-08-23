using System;
using UnityEngine;

public class GirlController : MonoBehaviour
{
    [SerializeField] private float girlSpeed = 0;
    private Vector3 position;
    [SerializeField] private float offset = 0;

    private void Awake()
    {
        position = transform.position;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, position, girlSpeed * Time.deltaTime);
    }
    public void FollowPosition(Vector3 targetPosition)
    {
        position.x = targetPosition.x - offset;
        position.y = -1.75f;
        position.z = 0;
    }
}
