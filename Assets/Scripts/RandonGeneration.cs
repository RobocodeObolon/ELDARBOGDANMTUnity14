using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMapGenerator : MonoBehaviour
{
    [Header("Розміри карти")]
    public int width = 10;
    public int height = 5;

    [Header("Префаби блоків")]
    public GameObject[] blockPrefabs;

    void Start()
    {
        GenerateMap();
    }

    void GenerateMap()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector2 spawnPosition = new Vector2(x, y);
                GameObject randomBlock = blockPrefabs[Random.Range(0, blockPrefabs.Length)];
                Instantiate(randomBlock, spawnPosition, Quaternion.identity, transform);
            }
        }
    }
}

    



