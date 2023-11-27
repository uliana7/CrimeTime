using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class LevelTransition : MonoBehaviour
{
    public GameObject Character;
    public GameObject Door;
    public int scene;
    public void changeScene()
    {
        SceneManager.LoadScene(scene);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)  && Vector3.Distance(Character.transform.position, Door.transform.position) <= 1 && Crossword.allWordsGuessed)
        {
            changeScene();
        }
    }

}
