using UnityEngine;

namespace Characters
{
    public class CharacterHealth : MonoBehaviour,IDamageable
    {
        [SerializeField] protected int health;
        protected int maxHealth;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        protected virtual void Awake()
        {
            maxHealth = health;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public virtual void MakeDamage(int damage)
        {
            health -= damage;
            AudioManager.Instance.PlayHitSound(0);
            if (health > 0) return;
            health = 0;
            Destroy(gameObject);
        }
    }
}
