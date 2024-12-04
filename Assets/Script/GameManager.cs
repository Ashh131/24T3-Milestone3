using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int CollectedCoin = 0;


    public void AddCollectedCoin(int amount)
    {
        CollectedCoin += amount;

        if (CollectedCoin >= 1)
        {
            SceneManager.LoadScene("End");
        }
    }
}


