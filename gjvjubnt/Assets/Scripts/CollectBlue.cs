using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBlue : MonoBehaviour
{
    public static int blue = 0;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
           
            gameObject.SetActive(false);
            blue++;
        }
    }


}
