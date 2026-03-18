using UnityEngine;

namespace Objects
{
    public class CameraScript : MonoBehaviour
    {
        private Transform player;
        [SerializeField] private Vector3 offset;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            player = GameObject.Find("Player").transform;
            offset = new Vector3(0, 3, -4);
        }

        // Update is called once per frame
        void Update()
        {
            FollowPlayer();
        }

        private void FollowPlayer()
        {
            if(!player) return;
            transform.position = player.position + player.rotation * offset;
            transform.LookAt(player.position);
        }
    }
}
