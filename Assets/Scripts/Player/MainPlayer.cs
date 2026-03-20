using Characters;
using Managers;
using UnityEngine;

namespace Player
{
    public class MainPlayer : MonoBehaviour
    {
        public Rigidbody Rb{get; private set;}

        public CharacterHealth Health { get; private set; }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        protected void Awake()
        {
            Rb = GetComponent<Rigidbody>();
            Health = GetComponent<CharacterHealth>();
        }

        protected void Start()
        {
            GamesManager.Instance.LoockCursor();
        }
    }
}
