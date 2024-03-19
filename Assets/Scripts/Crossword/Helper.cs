using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helper : MonoBehaviour
{
    public GameObject HelpMessage;
    public GameObject MainCharacter;
    public GameObject Object;
    public string typeObject;
    private double distanceValue;

    void Update()
    {
        if (typeObject == "paper")
            distanceValue = 1;
        else
            distanceValue = 3.5;

        if (Vector2.Distance((Vector2)MainCharacter.transform.position, (Vector2)Object.transform.position) <= distanceValue)
        {
            if (typeObject == "door")
                ShowDoorHelper();
            else
                ShowHelper();
        }
        else
        {
            HideHelper();
        }
    }

    public void ShowHelper()
    {
        HelpMessage.SetActive(true);
    }

    public void ShowDoorHelper()
    {
        HelpMessage.SetActive(true);/*
        if (Crossword.allWordsGuessed)
        {
            HelpMessage.SetActive(true);
        }*/
    }

    public void HideHelper()
    {
        HelpMessage.SetActive(false);
    }
}
