using System;
using Managers;
using UnityEngine;

public class Win : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.Win();
        }
    }
}
