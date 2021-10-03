using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JupiterSound : MonoBehaviour
{


    [SerializeField] AudioSource audioSourceBGM = default;
    [SerializeField] AudioClip audioClip = default;



    public void PlayBGMJupiter()
    {
        audioSourceBGM.clip = audioClip;
        audioSourceBGM.Play();
    }

    public void StopBGMJupiter()
    {
        audioSourceBGM.clip = audioClip;
        audioSourceBGM.Stop();
    }

    public void JupiterSoundPlay()
    {
        if (!audioSourceBGM.isPlaying)
        {
            PlayBGMJupiter();
            Debug.Log("Jupiter");
        }
    }

    public void JupiterSoundStop()
    {
        if (audioSourceBGM.isPlaying)
        {
            StopBGMJupiter();
            Debug.Log("JupiterStop");
        }
    }
}
