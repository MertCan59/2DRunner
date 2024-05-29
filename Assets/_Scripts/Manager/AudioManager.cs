using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        Collector.OnCoinCollectedSound += PlayAudio;
    }

    private void OnDisable()
    {
        Collector.OnCoinCollectedSound -= PlayAudio;
    }
    
    private void PlayAudio()
    {
        _audioSource.PlayOneShot(_audioClip);
    }
}
