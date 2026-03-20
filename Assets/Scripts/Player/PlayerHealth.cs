using Characters;
using Managers;

namespace Player
{
    public class PlayerHealth : CharacterHealth
    {
        protected override void Awake()
        {
            health = 100;
            base.Awake();
        }

        public void Start()
        {
            UIManager.Instance.ReloadHp(health, maxHealth);
        }
    
        public override void MakeDamage(int damage)
        {
            UIManager.Instance.ReloadHp(health-damage, maxHealth);
            StartCoroutine(UIManager.Instance.BloodEfect());
            base.MakeDamage(damage);
        }
    }
}
