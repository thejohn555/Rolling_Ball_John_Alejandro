using UnityEngine;

namespace Player
{
    public class PlayerMovementSystem : PlayerSystem
    {
        private float hInput;
        private float vInput;
        private float xInput;
        private float yInput;
        private float hRaycast;
        private bool isGrounded;
        
        [SerializeField] private float xMauseSpeed;
        [SerializeField] private float jumpForce;
        [SerializeField] private float moveForce;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        protected override void Awake()
        {
            base.Awake(); 
            hRaycast = transform.localScale.y + 0.02f;
            
        }

        // Update is called once per frame
        void Update()
        {
            Inputs();
            Jump();
            
            transform.Rotate(Vector3.up * xInput);
        }

        private void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isGrounded = Physics.Raycast(transform.position, Vector3.down, hRaycast);
                if (isGrounded)
                {
                    main.Rb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
                }
            }
        }

        private void Inputs()
        {
            xInput = Input.GetAxis("Mouse X")* xMauseSpeed * Time.deltaTime;
            hInput = Input.GetAxisRaw("Horizontal");
            vInput = Input.GetAxisRaw("Vertical");
        }

        void FixedUpdate()
        {
            main.Rb.AddRelativeForce(new Vector3(hInput,0,vInput)*moveForce,ForceMode.Force);
        }
    }
}
