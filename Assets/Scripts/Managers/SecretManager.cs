using UnityEngine;
using static Managers.UIManager;

namespace Managers
{
    public class SecretManager : MonoBehaviour
    {
        public int MaxCoins { get; set; }
        [SerializeField] private Collider collider;
        public static SecretManager Instance{ get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void CheckCoins()
        {
            if(!(UIManager.Instance.Coins >= MaxCoins)) return;
            collider.isTrigger = true;
        }
    }
}
