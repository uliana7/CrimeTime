using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public DialogueTrigger dt;
    private bool isStartDialogue = true;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(ShowDialog), 0.2f); 
    }

    public void ShowDialog()
    {
        if (isStartDialogue)
        {
            dt.StartDialogue_Trigger();
            isStartDialogue = false;
        }
    }
}
