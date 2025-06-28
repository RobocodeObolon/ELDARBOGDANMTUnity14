using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Кількість життів")]
    public int maxLives = 3;
    private int currentLives;

    void Start()
    {
        currentLives = maxLives;
    }

    public void TakeDamage(int amount)
    {
        currentLives -= amount;
        if (currentLives < 0)
            currentLives = 0;

        Debug.Log("Залишилось життів: " + currentLives);

        if (currentLives == 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log(gameObject.name + " помер!");
        // Можеш додати тут анімацію або перехід на іншу сцену
        Destroy(gameObject);
    }

    public void Heal(int amount)
    {
        currentLives += amount;
        if (currentLives > maxLives)
            currentLives = maxLives;
    }

    public int GetLives()
    {
        return currentLives;
    }
}

public class EnemyPatrol : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool movingRight = true;
}
     void Start()
       {
            rb = GetComponent<Rigidbody2D>();
          }
         rb = GetComponent<Rigidbody2D>();
       

    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        rb.velocity = new Vector2((movingRight ? 1 : -1) * moveSpeed, rb.velocity.y);

        // Перевіряємо край платформи
        RaycastHit2D groundInfo = Physics2D.Raycast(groundCheck.position, Vector2.down, 1f, groundLayer);
        if (!groundInfo.collider)
        {
            Flip();
        }
    }

    void Flip()
    {
        movingRight = !movingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }

    private void OnCollisionEnter2D(Collision2D collisio
