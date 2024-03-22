using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Approaching the folder. Press 'E' to interact.");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Leaving the folder.");
        }
    }
}
