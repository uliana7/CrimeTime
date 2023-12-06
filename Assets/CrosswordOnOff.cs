using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrosswordOnOff : MonoBehaviour
{
    public GameObject MainCharacter;
    public GameObject Paper;
    public DialogueTrigger dt;
    void Update()
    {
        if (Vector3.Distance(MainCharacter.transform.position, Paper.transform.position) <= 1)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                if (!Crossword.isCrosswordOn)
                {
                    CrosswordOn();
                }

            }
        }
        else if (Crossword.allWordsGuessed && !DialogueTrigger.isAlreadyShowEndCrossMonologue)
        {
            dt.EndCrosswordMonologue_Trigger();
        }
    }

    public void CrosswordOn()
    {
        SceneManager.LoadScene(4);
        Crossword.isCrosswordOn = true;
    }
}
