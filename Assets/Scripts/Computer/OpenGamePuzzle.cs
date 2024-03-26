using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventProxyScript : MonoBehaviour
{
    public GameObject windowToOpen;

    public void OpenWindow()
    {
        windowToOpen.SetActive(true);
    }
}
