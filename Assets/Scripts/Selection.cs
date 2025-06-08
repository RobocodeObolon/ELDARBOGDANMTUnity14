using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : Selecction.cs
{
    public enum ItemType { Coin, HealthPack, Weapon }
    public ItemType itemType;

    public int amount = 1;  // скільки дає монет чи здоров'я

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        switch (itemType)
        {
            case ItemType.Coin:
                // Додати монети гравцю
                Debug.Log("Підібрано монету");
                // GameManager.instance.AddCoins(amount);
                break;

            case ItemType.HealthPack:
                // Відновити здоров'я гравцю
                Debug.Log("Підібрано аптечку");
                // other.GetComponent<PlayerHealth>().Heal(amount);
                break;

            case ItemType.Weapon:
                Debug.Log("Підібрано зброю");
                // other.GetComponent<PlayerInventory>().AddWeapon(weaponPrefab);
                break;
        }

        Destroy(gameObject);  // прибираємо предмет зі сцени
    }
}
