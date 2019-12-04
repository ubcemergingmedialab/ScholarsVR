using UnityEngine;

public class Pencil : MonoBehaviour
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

    public static void PauseAudio()
    {
        audio.Pause();
    }

    public static void PauseOthers()
    {
        Eraser.PauseAudio();
        TalkingStudent.PauseAudio();
        Raccoon.PauseAudio();
    }
}