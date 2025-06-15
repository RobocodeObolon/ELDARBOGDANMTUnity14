using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureWin : MonoBehaviour
{
    public GameObject picture; 

    void Start()
    {
       
        if (picture != null)
        {
            picture.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player")) 
        {
            if (picture != null)
            {
                picture.SetActive(true);
            }
        }
    }
}