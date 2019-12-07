using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prof : MonoBehaviour
{

    private static Renderer renderer;
    private static Shader highlightShader;
    private static Renderer profRenderer;
    private static AudioSource audio;
    private static bool highlighted = false;

    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
        profRenderer = gameObject.GetComponent<Renderer>();
        highlightShader = Shader.Find("Highlight");
        audio = gameObject.GetComponent<AudioSource>();
}

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool IsPlaying()
    {
        return audio.isPlaying;
    }
}
