using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Crossword : MonoBehaviour
{
    public DialogueTrigger dt;
    public GameObject helper;

    public static bool allWordsGuessed = false;
    public static bool isCrosswordOn;

    private void Update()
    {
        if (isCrosswordOn && !allWordsGuessed && !DialogueTrigger.isAlreadyShowStartCrossMonologue)
            dt.StartCrosswordMonologue_Trigger();
    }

    public void CrosswordOff()
    {
        SceneManager.LoadScene(1);
        isCrosswordOn = false;
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
