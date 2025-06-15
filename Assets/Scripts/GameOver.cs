using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
    [SerializeField] private string gameOverSceneName = "GameOverScene";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Гравець програв. Завантажуємо сцену програшу...");
            SceneManager.LoadScene(gameOverSceneName);
        }
    }
}

