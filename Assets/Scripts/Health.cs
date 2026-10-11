using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;
    public float CurrentHealthPrecentage
    {
        get
        {
            return (float)CurrentHealth / (float)MaxHealth;
        }
    }
    private Character _cc;//script

    public EnemyHealthBar healthBar;

    private void Awake()
    {
        CurrentHealth = MaxHealth;
        _cc = GetComponent<Character>();

        if (healthBar == null)
        {
            healthBar = GetComponentInChildren<EnemyHealthBar>();
        }
    }

    public void ApplyDamage(int Damage)
    {
        CurrentHealth -= Damage;

        if (CurrentHealth < 0) CurrentHealth = 0;

        // Cập nhật lên thanh máu Slider UI
        if (healthBar != null)
        {
            healthBar.UpdateHealth(CurrentHealth, MaxHealth);
        }

        CheckHealth();
    }

    private void CheckHealth()
    {
        if (CurrentHealth <= 0)
        {
            _cc.SwitchStateTo(Character.CharacterState.Dead);
        }
    }
    public void AddHealth(int value)
    {
        CurrentHealth += value;
        if (CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }

        // Cập nhật lên thanh máu Slider UI
        if (healthBar != null)
        {
            healthBar.UpdateHealth(CurrentHealth, MaxHealth);
        }
    }
}
