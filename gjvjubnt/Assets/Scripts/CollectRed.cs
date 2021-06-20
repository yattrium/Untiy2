using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectRed : MonoBehaviour
{
    public static int red = 0;

    void OnTriggerEnter(Collider plyr)
    {

        if (plyr.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            red++;
           // Debug.Log(red);
        }

        if (red == 5)
        {
            SceneManager.LoadScene(3);
        }

    }


}
