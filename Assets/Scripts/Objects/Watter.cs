using System;
using Player;
using UnityEngine;

namespace Objects
{
    public class Watter : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out PlayerHealth health))
            {
                health.MakeDamage(1000);
            }
        }
    }
}
