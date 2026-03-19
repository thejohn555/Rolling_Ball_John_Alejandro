using System;
using System.Diagnostics;
using Interfaces;
using UnityEngine;

namespace Objects
{
    public class Coin : MonoBehaviour , IInteractuable
    {
        [SerializeField] private float speedRotation;
        [SerializeField] private float speedUpAndDown;
        [SerializeField] private float timerLimit;
        private float timer;
        public void Update()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * speedRotation));
            timer += Time.deltaTime;
            if (timer > timerLimit)
            {
                speedUpAndDown *= -1;
                timer = 0;
            }
            transform.Translate(Vector3.up * (Time.deltaTime * speedUpAndDown));
        }

        public void Interact()
        {
            UIManager.instance.Coins += 1;
            UIManager.instance.ReloadText();
            Destroy(gameObject);
        }
    }
}
