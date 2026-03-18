using System;
using Characters;

public class PlayerHealth : CharacterHealth
{
    public void Awake()
    {
        health = 100;
        maxHealth = health;
    }

    public void Start()
    {
        UIManager.instance.ReloadHp(health, maxHealth);
    }
    
    public override void MakeDamage(int damage)
    {
        base.MakeDamage(damage);
        UIManager.instance.ReloadHp(health, maxHealth);
        StartCoroutine(UIManager.instance.ReloadVisualHp());
    }
}
