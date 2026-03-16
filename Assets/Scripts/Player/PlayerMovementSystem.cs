using UnityEngine;

namespace Player
{
    public class PlayerMovementSystem : PlayerSystem
    {
        private float hInput;
        private float vInput;
        [SerializeField]private float moveForce;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            HVInputs();
        }

        private void HVInputs()
        {
            hInput = Input.GetAxisRaw("Horizontal");
            vInput = Input.GetAxisRaw("Vertical");
        }

        void FixedUpdate()
        {
            main.Rb.AddRelativeForce(new Vector3(hInput,0,vInput)*moveForce,ForceMode.Force);
        }
    }
}
