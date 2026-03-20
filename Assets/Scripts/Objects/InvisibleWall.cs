using System;
using UnityEngine;

public class InvisibleWall : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            meshRenderer.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            meshRenderer.enabled = true;
        }
    }
}
