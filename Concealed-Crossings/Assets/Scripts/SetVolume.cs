using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    [SerializeField] string whichChannel;

    public void SetLevel (float sliderValue)
    {
        mixer.SetFloat(whichChannel, Mathf.Log10(sliderValue) * 20);
    }
}
