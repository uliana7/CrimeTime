using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper : MonoBehaviour
{
    public GameObject HelpMessage;
    public GameObject MainCharacter;
    public GameObject Object;
    public string typeObject;

    void Update()
    {
        if (Vector3.Distance(MainCharacter.transform.position, Object.transform.position) <= 1)
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
        if (Crossword.allWordsGuessed)
            HelpMessage.SetActive(true);
    }

    public void HideHelper()
    {
        HelpMessage.SetActive(false);
    }
}
