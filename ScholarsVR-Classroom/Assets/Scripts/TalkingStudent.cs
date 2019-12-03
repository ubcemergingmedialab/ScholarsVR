using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingStudent : MonoBehaviour
{
    private static AudioSource audio;
    private static Light light;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlayAudio()
    {
        audio.Play();
        light.enabled = true;
        GameObject.Find("StudentSpeechBubble").SetActive(true);

    }
}
