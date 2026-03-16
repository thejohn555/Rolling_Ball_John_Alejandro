using UnityEngine;

namespace Player
{
    public class PlayerSystem : MonoBehaviour
    {
        protected MainPlayer main;

        protected virtual void Awake()
        {
            main = transform.root.GetComponent<MainPlayer>();
        }
    }
}
