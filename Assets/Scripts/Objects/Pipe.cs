using Interfaces;
using Player;
using UnityEngine;

namespace Objects
{
    public class Pipe : MonoBehaviour,IInteractuable
    {
        [SerializeField] private Transform tpPoint;
        private BoxCollider boxCollider;
        private bool isTouching;
        private Transform player;

        private float hPipe;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            boxCollider = GetComponent<BoxCollider>();
        
            hPipe = boxCollider.size.y;
        
        }

        // Update is called once per frame
        void Update()
        {
            if (!isTouching) return;
            if (Input.GetKeyDown(KeyCode.F))
            {
                player.position = tpPoint.position;
            }
        }

        private void OnCollisionEnter(Collision other)
        {
            if (!other.gameObject.TryGetComponent(out MainPlayer player)) return;
            this.player = player.transform;
            isTouching = true;
        }
        private void OnCollisionExit(Collision other)
        {
            if (!other.gameObject.TryGetComponent(out MainPlayer player)) return;
            this.player = null;
            isTouching = false;
        }

        public void Interact()
        {
        
        }
    }
}
