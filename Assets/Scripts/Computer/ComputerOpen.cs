using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenWindow : MonoBehaviour
{
    public GameObject windowPanel;
    public GameObject additionalPanel;
    public KeyCode openCloseKey;
    public float delayTime = 3f;

    private bool isOpen = false;

    void Update()
    {
        if (Input.GetKeyDown(openCloseKey))
        {
            isOpen = !isOpen;
            windowPanel.SetActive(isOpen);

            if (isOpen)
            {
                StartCoroutine(OpenAdditionalPanel());
            }
        }
    }

    IEnumerator OpenAdditionalPanel()
    {
        yield return new WaitForSeconds(delayTime);

        windowPanel.SetActive(false);

        additionalPanel.SetActive(true);
    }
}
