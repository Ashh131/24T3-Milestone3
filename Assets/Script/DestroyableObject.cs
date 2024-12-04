using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour
{
    void OnCollisionEnter(Collision boom)
    {
        if (boom.gameObject.CompareTag("Player"))
        {
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager != null)
            {
                gameManager.AddCollectedCoin(1);
                Destroy(gameObject);
            }
        }
    }




}

