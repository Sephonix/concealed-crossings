using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFPS : MonoBehaviour
{
    public GameObject FPSCounter;

    void Start()
    {
        FPSCounter.SetActive(false);
    }


    public void ToggleChanged(bool isToggled)
    {
        FPSCounter.SetActive(isToggled);
    }
}
