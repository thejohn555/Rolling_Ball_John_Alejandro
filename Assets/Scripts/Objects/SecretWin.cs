using Managers;
using UnityEngine;

namespace Objects
{
    public class SecretWin : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                GamesManager.Instance.SecretWin();
            }
        }
    }
}
