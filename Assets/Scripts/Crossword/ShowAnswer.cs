using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class ShowAnswer : MonoBehaviour
{
    public string answer;
    public int answerNumber;
    public int letterNumber;
    public static int guessedLettersCount;
    private Text Text;
    private int count;
    void Start()
    {
        Text = GetComponent<Text>();
    }

    private void Update()
    {
        if (InputAnswer.Answer == answer && answerNumber == QuestionManager.PressButtonCounter)
        {
            count++;
            Text.text = InputAnswer.Answer.ToUpper()[letterNumber].ToString();
            if (count == answer.Length)
                guessedLettersCount++;
        }

        if (guessedLettersCount == 116)
        {
            Crossword.allWordsGuessed = true;
        }
    }
}
