using UnityEngine;

namespace Objects
{
    public class SecretWin : MonoBehaviour
    {
        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                GameManager.Instance.SecretWin();
            }
        }
    }
}
