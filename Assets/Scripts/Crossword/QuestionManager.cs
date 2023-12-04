using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    [Header("Вопросы")]
    public string Question1;
    public string Question2;
    public string Question3;
    public string Question4;
    public string Question5;
    public string Question6;
    public string Question7;
    public string Question8;
    public string Question9;
    public string Question10;
    public string Question11;
    public string Question12;
    public string Question13;
    public string Question14;
    public string Question15;
    public string Question16;
    public string LastWord;

    public static int PressButtonCounter;
    public Text Text;
    public InputField inputField;

    void Start()
    {
        PressButtonCounter = 0;
        Text.text = Question1;
    }

    void Update()
    {
        switch(PressButtonCounter)
        {
            case 0:
                Text.text = Question1;
                break;
            case 1:
                Text.text = Question2;
                break;
            case 2:
                Text.text = Question3;
                break;
            case 3:
                Text.text = Question4;
                break;
            case 4:
                Text.text = Question5;
                break;
            case 5:
                Text.text = Question6;
                break;
            case 6:
                Text.text = Question7;
                break;
            case 7:
                Text.text = Question8;
                break;
            case 8:
                Text.text = Question9;
                break;
            case 9:
                Text.text = Question10;
                break;
            case 10:
                Text.text = Question11;
                break;
            case 11:
                Text.text = Question12;
                break;
            case 12:
                Text.text = Question13;
                break;
            case 13:
                Text.text = Question14;
                break;
            case 14:
                Text.text = Question15;
                break;
            case 15:
                Text.text = Question16;
                break;
            case 16:
                Text.text = LastWord;
                break;
            default:
                    break;
        }
    }

    public void PressNextButton()
    {
        if (PressButtonCounter >= 16)
            return;
        PressButtonCounter++;
        inputField.Select();
        inputField.text = "";
    }

    public  void PressPreviosButton()
    {
        if (PressButtonCounter <= 0)
            return;
        PressButtonCounter--;
        inputField.Select();
        inputField.text = "";
    }
}
