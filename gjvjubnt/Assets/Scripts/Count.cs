using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count : MonoBehaviour
{
     GameObject objUIBlue;
     GameObject objUIPink;
     GameObject objUI;
    bool Cvetochki = false;

    // Start is called before the first frame update
    void Start()
    {
        objUIBlue = GameObject.Find("BlueNum");
        objUIPink = GameObject.Find("PinkNum");
        objUI = GameObject.Find("ObjNum");

    }

    // Update is called once per frame
    void Update()
    {
        objUIBlue.GetComponent<Text>().text = "���������: " + CollectBlue.blue.ToString();
        objUIPink.GetComponent<Text>().text = "�������: " + CollectePink.pink.ToString();

        if (CollectBlue.blue >= 5 && CollectePink.pink >= 5)
        {
            objUIBlue.GetComponent<Text>().text = "";
            objUIPink.GetComponent<Text>().text = "";
            objUI.GetComponent<Text>().text = "������� ���������� ������!";
            Cvetochki = true;
        }


    }

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player" && Cvetochki == true)
        {
            SceneManager.LoadScene(4);
        }
        else 
        {
            SceneManager.LoadScene(3);
        }

    }

}
