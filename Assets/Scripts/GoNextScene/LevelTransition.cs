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
    public Vector3 positionPerson;
    public VectorValue playerStorage;

    public void ChangeScene()
    {
        playerStorage.initialValue = positionPerson;
        SceneManager.LoadScene(scene);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Vector3.Distance(Character.transform.position, Door.transform.position) <= 3.5 /*&& Crossword.allWordsGuessed*/)
        {
            Player.isStartMonologue = false;
            ChangeScene();
        }
    }

}
