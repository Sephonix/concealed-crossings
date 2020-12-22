using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteSound : MonoBehaviour
{

    public void MuteToggle(bool isMute)
    {

            isMute = !isMute;
            AudioListener.volume = isMute ? 0 : 1;

    }
}
