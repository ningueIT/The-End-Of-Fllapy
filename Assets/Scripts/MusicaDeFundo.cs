using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaDeFundo : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
}