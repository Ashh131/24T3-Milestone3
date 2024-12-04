using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager1 : MonoBehaviour
{
    public void NewLevelBTN(string newLevel)
    {
        SceneManager.LoadScene(newLevel);
    }

    public void ExitGameBTN()
    {
        Application.Quit();
    }
}
