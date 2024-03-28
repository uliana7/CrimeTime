using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleComplete : MonoBehaviour
{
    int fullElement;
    public static int curElement;
    public Image allPuzzle;
    public Image puzzlePanel;
    public Image completePanel;

    void Start()
    {
        fullElement = allPuzzle.transform.childCount;
    }

    void Update()
    {
        if (fullElement == curElement)
        {
            puzzlePanel.gameObject.SetActive(false);
            completePanel.gameObject.SetActive(true);
        }
    }

    public static void AddElement()
    {
        curElement++;
    }
}
