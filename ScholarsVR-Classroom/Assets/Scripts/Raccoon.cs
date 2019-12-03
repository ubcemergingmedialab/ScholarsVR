using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raccoon : MonoBehaviour
{
    private static AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlayAudio()
    {
        audio.Play();
    }
}
