using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputAnswer : MonoBehaviour
{
    public static string Answer;
    public Text inputText;

    void Start()
    {   
    }

    void Update()
    {
        Answer = inputText.text.ToString().ToLower();
    }
}
