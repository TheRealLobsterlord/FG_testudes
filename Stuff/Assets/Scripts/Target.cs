using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI HP;
    public float health = 50f;

    public void TakeDamage (float amount)
    {
        health -= amount;
        UpdateHp();
        if (health <= 0f)
        {
            Die();
        }

    }
    void Die ()
    {
        Destroy(gameObject);
    }
    private void UpdateHp()
    {
        health.ToString("Hp ");

    }
}
