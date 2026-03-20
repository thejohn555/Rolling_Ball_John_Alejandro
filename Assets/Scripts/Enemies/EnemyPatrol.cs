using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Enemies
{
    public class EnemyPatrol : MonoBehaviour
    {
        [SerializeField]private Transform patrolPath;
        [SerializeField]private int patrolSpeed;
        private List<Vector3> patrolPositions = new ();
        private Vector3 currentPosition;
        private int currentIndex;
        private void Awake()
        {
            foreach (Transform partolPoint in patrolPath)
            {
                patrolPositions.Add(partolPoint.position);
            }
            StartCoroutine(PatrolAndWait());
        }
        private IEnumerator PatrolAndWait()
        {
            while (true)
            {
                CalculateNewDestination();
                FaceToDestination();
                while (transform.position != currentPosition)
                {
                    transform.position = Vector3.MoveTowards(transform.position, currentPosition, patrolSpeed * Time.deltaTime);
                    yield return new Null();
                }
                yield return new WaitForSeconds(Random.Range(0.2f, 2.5f));
                currentIndex = (currentIndex+1) % patrolPositions.Count;
            }
            
        }
        private void FaceToDestination()
        {
            float x = currentPosition.x - transform.position.x;
            switch (Mathf.Sign(x))
            {
                case -1:
                    transform.eulerAngles = new Vector3(0, 180, 0);
                    break;
                case 1:
                    transform.eulerAngles = Vector3.zero;
                    break;
            }
        }
        private void CalculateNewDestination()
        {
            currentPosition = patrolPositions[currentIndex];
        }
    }
}
