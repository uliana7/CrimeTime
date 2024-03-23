using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleComplete : MonoBehaviour
{
    int fullElement;
    public static int curElement;
    public GameObject allPuzzle;
    public GameObject puzzlePanel;
    public GameObject completePanel;


    // Start is called before the first frame update
    void Start()
    {
        fullElement = allPuzzle.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (fullElement == curElement)
        {
            puzzlePanel.SetActive(false);
            completePanel.SetActive(true);
        }
    }

    public static void AddElement()
    {
        curElement ++;
    }
}
