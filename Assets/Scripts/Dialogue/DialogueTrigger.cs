using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueManager dm;
    public GameObject Player;
    public static bool isAlreadyShowEndCrossMonologue = false;
    public static bool isAlreadyShowStartCrossMonologue = false;

    [Header("Монологи игрока")]
    public Dialogue StartMonologue;
    public Dialogue StartCrosswordMonologue;
    public Dialogue EndCrosswordMonologue;

    public void CantMove()
    {
        Player.GetComponent<PlayerMove>().enabled = false;
        Player.GetComponent<Animator>().enabled = false;
    }

    public void CanMove()
    {
        if (dm.counter == 0)
        {
            Player.GetComponent<PlayerMove>().enabled = true;
            Player.GetComponent<Animator>().enabled = true;
            CancelInvoke(nameof(CanMove));
        }
    }

    //Монологи игрока
    public void StartMonologue_Trigger()
    {
        dm.StartDialogue(StartMonologue);
        CantMove();
        InvokeRepeating(nameof(CanMove), 0, 1);
    }

    public void StartCrosswordMonologue_Trigger()
    {
        dm.StartDialogue(StartCrosswordMonologue);
        CantMove();
        InvokeRepeating(nameof(CanMove), 0, 1);
        isAlreadyShowStartCrossMonologue = true;
    }

    public void EndCrosswordMonologue_Trigger()
    {
        dm.StartDialogue(EndCrosswordMonologue);
        CantMove();
        InvokeRepeating(nameof(CanMove), 0, 1);
        isAlreadyShowEndCrossMonologue = true;
    }
}
