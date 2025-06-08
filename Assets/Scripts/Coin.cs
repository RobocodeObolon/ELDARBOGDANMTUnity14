using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : coiin.сs
{
    // Опціонально: можна додати посилання на менеджер грошей або UI, щоб збільшувати рахунок

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Перевіряємо, чи гравець торкнувся монети
        if (other.CompareTag("Player"))
        {
            // ТУТ можна додати логіку збільшення балів, наприклад:
            // GameManager.instance.AddScore(1);

            Debug.Log("Монета підібрана!");

            // Знищуємо монету зі сцени
            Destroy(gameObject);
        }
    }
}

