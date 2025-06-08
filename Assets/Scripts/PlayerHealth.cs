using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    private Animator animator;
    private Rigidbody2D rb;
    private bool isDead = false;

    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currentHealth -= damage;
        Debug.Log("HP: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
        else
        {
            // Можна додати ефект пошкодження (мерехтіння, звук тощо)
            animator.SetTrigger("Hurt");
        }
    }

    void Die()
    {
        isDead = true;
        Debug.Log("Гравець помер");
        rb.velocity = Vector2.zero;
        animator.SetTrigger("Death");
        // Додай логіку рестарту рівня або показу меню смерті
    }

    // Якщо хочеш, щоб при зіткненні з ворогом отримував шкоду:
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
    }
}
