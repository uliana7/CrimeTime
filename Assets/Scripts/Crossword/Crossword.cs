using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Crossword : MonoBehaviour
{
    public DialogueTrigger dt;
    public GameObject crossword;
    public GameObject helper;
    public GameObject MainCharacter;
    public GameObject Paper;
    public GameObject PauseButton;

    [Header("Монолог перед заупском кроссворда")]
    public Dialogue StartMonologue;

    public static bool allWordsGuessed = true;
    private bool isCrosswordOn;


    void Update()
    {
        if (Vector3.Distance(MainCharacter.transform.position, Paper.transform.position) <= 1)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                if (!isCrosswordOn)
                {
                    CrosswordOn();
                }
            }
            else if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (isCrosswordOn)
                {
                    CrosswordOff();
                }    
            }
        }
    }

    public void CrosswordOff()
    {
        if (allWordsGuessed && !DialogueTrigger.isAlreadyShowEndCrossMonologue)
            dt.EndCrosswordMonologue_Trigger();
        crossword.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 1f;
        isCrosswordOn = false;
    }

    public void CrosswordOn()
    {
        if (!allWordsGuessed && !DialogueTrigger.isAlreadyShowStartCrossMonologue)
            dt.StartCrosswordMonologue_Trigger();
        crossword.SetActive(true);
        PauseButton.SetActive(false);
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
