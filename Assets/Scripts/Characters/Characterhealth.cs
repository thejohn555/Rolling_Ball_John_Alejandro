using UnityEngine;

namespace Characters
{
    public class Characterhealth : MonoBehaviour,IDamageable
    {
        private int health;
        private int maxHealth;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void MakeDamage(int damage)
        {
            health -= damage;
            if (health > 0) return;
            health = 0;
            Destroy(gameObject);
        }
    }
}
