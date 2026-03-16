using System;
using Interfaces;
using UnityEngine;

namespace Objects
{
    public class Coin : MonoBehaviour , IInteractuable
    {
        public void Interact()
        {
            UIManager.instance.Coins += 1;
            UIManager.instance.ReloadText();
            Destroy(gameObject);
        }
    }
}
