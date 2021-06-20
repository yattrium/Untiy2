using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextText : MonoBehaviour
{
    public GameObject Panel;
    public GameObject OpenedPanel;

    public void OpenPanel()
    {

        if (Panel != null)
        {
            OpenedPanel.SetActive(false);
            Panel.SetActive(true);

        }
    }
}
