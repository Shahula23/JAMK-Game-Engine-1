using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MixerLevels : MonoBehaviour
{
    public Slider masterVolume;
    public AudioMixer masterMixer;
    // Start is called before the first frame update
    void Start()
    {
        masterVolume.value = PlayerPrefs.GetFloat("Master", 1f);
        masterMixer.SetFloat("Master", Mathf.Log10(masterVolume.value) * 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMasterVolumeLevel(float volumeLevel)
    {
        masterMixer.SetFloat("Master", Mathf.Log10(volumeLevel) * 20);
        PlayerPrefs.SetFloat("Master", volumeLevel);
    }
}
