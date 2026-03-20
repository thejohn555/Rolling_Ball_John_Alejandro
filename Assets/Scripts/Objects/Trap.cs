using System;
using TMPro;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [field: SerializeField] public int Damage { get; private set; }
    [SerializeField] private float timerTrap;

    private float timer;
    public bool Active { get; set; }
    public MeshRenderer MeshRenderer { get; private set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnEnable()
    {
        MeshRenderer = GetComponent<MeshRenderer>();
        MeshRenderer.enabled = true;
        Active = true;
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    private void Timer()
    {
        timer += Time.deltaTime;
        if (!(timer > timerTrap)) return;
        Active = !Active;
        MeshRenderer.enabled = !MeshRenderer.enabled;
        timer = 0;
    }

    private void OnTriggerStay(Collider other)
    {
        if (!Active) return;
        if (other.TryGetComponent(out IDamageable damageable))
        {
            damageable.MakeDamage(Damage);
            Active = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!Active) return;
        if (other.TryGetComponent(out IDamageable damageable))
        {
            Active = true;
        }
    }
}
