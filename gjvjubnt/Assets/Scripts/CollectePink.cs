using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectePink : MonoBehaviour
{
    public static int pink = 0;


    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
           
            gameObject.SetActive(false);
            pink++;

        }
    }




}
