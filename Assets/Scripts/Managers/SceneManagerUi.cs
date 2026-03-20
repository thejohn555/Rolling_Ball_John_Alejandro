using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class SceneManagerUi : MonoBehaviour
    {
        public static SceneManagerUi Instance{ get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(this);
            }
        }

        public void ChangeScene(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);
        }
        
        public void Exit()
        {
            Application.Quit();
        }
    }
}
