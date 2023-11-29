using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueManager dm;
    public GameObject Player;

    [Header("�������� ������")]
    public Dialogue StartDialogue;


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

    //�������� ������
    public void StartDialogue_Trigger()
    {
        dm.StartDialogue(StartDialogue);
        CantMove();
        InvokeRepeating(nameof(CanMove), 0, 1);
    }
}
