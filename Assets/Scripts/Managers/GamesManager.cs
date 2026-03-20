using UnityEngine;

namespace Managers
{
    public class GamesManager : MonoBehaviour
    {
    
        [SerializeField] private GameObject win;
        [SerializeField] private GameObject secretWin;
        [SerializeField] private GameObject loss;
    
        public static GamesManager Instance{get; private set;}

        public void Awake()
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

        public void Win()
        {
            AudioManager.Instance.PlaySound(1);
            win.SetActive(true);
            UnLoockCursor();
        }
    
        public void SecretWin()
        {
            AudioManager.Instance.PlaySound(1);
            secretWin.SetActive(true);
            UnLoockCursor();
        }

        public void Lose()
        {
            AudioManager.Instance.PlaySound(2);
            loss.SetActive(true);
            UnLoockCursor();
        }
        public void UnLoockCursor()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        public void LoockCursor()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
