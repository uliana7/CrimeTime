using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper : MonoBehaviour
{
    public GameObject Button;
    public GameObject MainCharacter;
    public GameObject Paper;

    void Update()
    {
        if (Vector3.Distance(MainCharacter.transform.position, Paper.transform.position) <= 1)
        {
            ShowButton();
        }
        else
        {
            HideButton();
        }
    }

    public void ShowButton()
    {
        Button.SetActive(true);
    }

    public void HideButton()
    {
        Button.SetActive(false);
    }
}
