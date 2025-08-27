using System;
using UnityEngine;
using System.Collections.Generic;

public class GirlController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private int delayFrames = 0;
    [SerializeField] private float moveSpeed = 0;
    [SerializeField] private float offsetX = 0;
    private float offsetY = 0;
    [SerializeField] private Queue<Vector3> positionHistory = new Queue<Vector3>();
    private Vector3 lastRecordedPos;

    void awake()
    {
        offsetY = target.position.y - transform.position.y ;
    }
    void Update()
    {
        // 必ず記録する
        positionHistory.Enqueue(target.position);

        if (positionHistory.Count > delayFrames)
        {
            Vector3 nextPos = positionHistory.Dequeue();
            nextPos.x -= offsetX;
            nextPos.y -= offsetY;

            // もし同じ位置なら動かない
            if ((nextPos - transform.position).sqrMagnitude > 0.0001f)
            {
                transform.position = Vector3.MoveTowards(transform.position, nextPos, moveSpeed * Time.deltaTime);
            }
        }
    }
}
