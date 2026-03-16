using System;
using Interfaces;
using UnityEngine;

namespace Player
{
    public class PlayerInteracSystem : PlayerSystem
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IInteractuable interactuable))
            {
                interactuable.Interact();
            }
        }
    }
}
