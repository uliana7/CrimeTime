using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputAnswer : MonoBehaviour
{
    public static string Answer;
    private Text inputText;

    void Start()
    {
        inputText = GetComponent<Text>();
    }

    void Update()
    {
        Answer = inputText.text.ToString().ToLower();
    }
}
