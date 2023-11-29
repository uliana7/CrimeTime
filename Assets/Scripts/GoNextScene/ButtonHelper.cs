using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHelper : MonoBehaviour
{
    public GameObject button2;
    public GameObject Character;
    public GameObject Door;

    void Update()
    {
        if (Vector3.Distance(Character.transform.position, Door.transform.position) <= 1 /*&& Crossword.allWordsGuessed*/)
        {
            ShowButton2();
        }
        else
        {
            HideButton2();
        }
    }

    public void ShowButton2()
    {
        button2.SetActive(true);
    }

    public void HideButton2()
    {
        button2.SetActive(false);
    }
}