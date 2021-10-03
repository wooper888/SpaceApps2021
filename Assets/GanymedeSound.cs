using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GanymedeSound : MonoBehaviour
{
    [SerializeField] AudioSource audioSourceBGM = default;
    [SerializeField] AudioClip audioClip = default;



    public void PlayBGM()
    {
        audioSourceBGM.clip = audioClip;
        audioSourceBGM.Play();
    }

    public void StopBGM()
    {
        audioSourceBGM.clip = audioClip;
        audioSourceBGM.Stop();
    }

    public void SoundPlay()
    {
        if (!audioSourceBGM.isPlaying)
        {
            PlayBGM();
        }
    }

    public void SoundStop()
    {
        if (audioSourceBGM.isPlaying)
        {
            StopBGM();
        }
    }
}
