using Characters;
using UnityEngine;

namespace Player
{
    public class MainPlayer : MonoBehaviour
    {
        public Rigidbody Rb{get; private set;}

        public Characterhealth Health { get; private set; }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        protected void Awake()
        {
            Rb = GetComponent<Rigidbody>();
            Health = GetComponent<Characterhealth>();
        }

        protected void Start()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
