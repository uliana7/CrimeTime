using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Crossword : MonoBehaviour
{
    private bool isCrosswordOn;
    public GameObject crossword;
    public GameObject helper;
    public GameObject MainCharacter;
    public GameObject Paper;
    public static bool allWordsGuessed = false;

    void Update()
    {
        if (Vector3.Distance(MainCharacter.transform.position, Paper.transform.position) <= 1)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                if (isCrosswordOn)
                {
                        CrosswordOff();
                }
                else
                {
                    CrosswordOn();
                }
            }
        }
    }

    public void CrosswordOff()
    {
        if (allWordsGuessed)
        {
            crossword.SetActive(false);
            Time.timeScale = 1f;
            isCrosswordOn = false;
        }
    }

    public void CrosswordOn()
    {
        crossword.SetActive(true);
        Time.timeScale = 0f;
        isCrosswordOn = true;
    }

    public void HelperOn()
    {
        helper.SetActive(true);
    }

    public void HelperOff()
    {
        helper.SetActive(false);
    }
}
