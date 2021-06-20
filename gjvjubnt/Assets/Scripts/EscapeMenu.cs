using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EscapeMenu : MonoBehaviour
{
    public bool EscMenIsOpen = true;
    public GameObject escape;
    public GameObject restart;

    // Update is called once per frame


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscMenIsOpen = !EscMenIsOpen;

           if (EscMenIsOpen == true)
            {
            escape.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
            }

            if (EscMenIsOpen == false)
            {
                escape.gameObject.SetActive(false);
                restart.gameObject.SetActive(false);
            }

            
        
        }
    }
    public void Escape()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}

