using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float currentHealth;
    public float CurrentHealth => currentHealth;
    public event Action OnHealthChanged;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (CompareTag("Player") && collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(5);
            Debug.Log(currentHealth);
        }
    }

    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        OnHealthChanged?.Invoke();
    }
}
