using UnityEngine;

namespace Characters
{
    public class CharacterHealth : MonoBehaviour,IDamageable
    {
        protected int health;
        protected int maxHealth;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public virtual void MakeDamage(int damage)
        {
            health -= damage;
            if (health > 0) return;
            health = 0;
            Destroy(gameObject);
        }
    }
}
