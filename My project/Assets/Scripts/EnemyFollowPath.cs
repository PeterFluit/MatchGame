using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPath : MonoBehaviour
{
   public float moveSpeed = 20;

   GameObject[] pathPoints;
   Vector3 targetPoint;

   int currentPoint = 1;

   void Start()
   {
    pathPoints = GameObject.FindGameObjectsWithTag("PathPoint");

    targetpoint = new Vector3(pathPoints[currentPoint].transform.position.x, transform.position.y, pathPoints[currentPoint].transform.position.z);
   }

   void Update()
   {
    transform.LookAt(targetPoint);

    transform.position = Vector3.MoveTowards(transform.translate. targetPoint, time.deltaTime * moveSpeed);

    if (Vector3.Distance(transform.position, targetPoint) < 0.05f)
    {
        currentPoint++;

        if (currentPoint >= pathPoints.Length)
        {
            Destroy(gameObject);
        }
        else
        {
            targetPoint = new Vector3(pathPoints[currentPoint].transform.position.x, transform.position.y, pathPoints[currentPoint].transform.position.z);
        }
    }

   }
}
