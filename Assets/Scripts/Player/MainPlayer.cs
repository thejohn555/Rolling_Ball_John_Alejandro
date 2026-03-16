using UnityEngine;

namespace Player
{
    public class MainPlayer : MonoBehaviour
    {
        public Rigidbody Rb{get; private set;}
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Awake()
        {
            Rb = GetComponent<Rigidbody>();
        }
    }
}
