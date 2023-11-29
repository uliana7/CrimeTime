using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public DialogueTrigger dt;
    public static bool isStartMonologue = true;

    void Start()
    {
        Invoke(nameof(ShowDialog), 0.2f); 
    }

    public void ShowDialog()
    {
        if (isStartMonologue)
        {
            dt.StartMonologue_Trigger();
            isStartMonologue = false;
        }
    }
}
