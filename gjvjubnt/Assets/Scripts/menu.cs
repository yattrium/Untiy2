using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(5);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
