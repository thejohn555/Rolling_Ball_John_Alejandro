using Interfaces;
using Player;
using UnityEngine;

namespace Objects
{
    public class Pipe : MonoBehaviour
    {
        [SerializeField] private Transform tpPoint;
        private bool isTouching;
        public bool Correct { get; set; }
        private Transform player;

        void Awake()
        {
            Correct = false;
        }

        void Update()
        {
            if (!isTouching||!Correct) return;
            if (Input.GetKeyDown(KeyCode.F))
            {
                player.position = tpPoint.position;
            }
        }

        private void OnCollisionEnter(Collision other)
        {
            if (!other.gameObject.CompareTag("Player")) return;
            player = other.transform;
            isTouching = true;
        }
        private void OnCollisionExit(Collision other)
        {
            if (!other.gameObject.CompareTag("Player")) return;
            isTouching = false;
            player = null;
        }
    }
}
