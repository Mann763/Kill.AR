using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsManager : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void mastervolume(float volume)
    {
        audioMixer.SetFloat("Master", volume);
    }
}
