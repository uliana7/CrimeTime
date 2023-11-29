using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnim : MonoBehaviour
{
    public DialogueManager dm;
    public GameObject button;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        button.SetActive(true);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        button.SetActive(false);
        dm.EndDialogue();
    }
}
