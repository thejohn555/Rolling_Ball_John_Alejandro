using System;
using Characters;
using Unity.VisualScripting;
using UnityEngine;

namespace Player
{
    public class PlayerCombatSystem : PlayerSystem
    {
        
        [SerializeField] private int damage;
 
        private void OnCollisionEnter(Collision other)
        {
            if (!other.gameObject.TryGetComponent(out CharacterHealth health)) return;
            Vector3 direction = other.transform.position - transform.position;
            if (Vector3.Dot(direction, transform.up) < 0)
            {
                health.MakeDamage(damage);
            }
        }
    }
}
