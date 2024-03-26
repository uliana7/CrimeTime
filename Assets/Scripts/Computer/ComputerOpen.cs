using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenWindow : MonoBehaviour
{
    public GameObject windowPanel;
    public KeyCode openCloseKey;

    void Update()
    {
        if (Input.GetKeyDown(openCloseKey))
        {
            if (windowPanel.activeSelf)
            {
                windowPanel.SetActive(false);
            }
            else
            {
                windowPanel.SetActive(true);
            }
        }
    }
}
