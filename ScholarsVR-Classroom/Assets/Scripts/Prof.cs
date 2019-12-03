using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prof : MonoBehaviour
{

    private static Renderer renderer;
    private static Shader highlightShader;
    private static Renderer profRenderer;
    private static bool highlighted = false;

    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
        profRenderer = gameObject.GetComponent<Renderer>();
        highlightShader = Shader.Find("Highlight");
}

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void HighlightObject()
    {
        foreach (Material material in renderer.materials)
        {
            material.color = new Color(material.color.r, material.color.g, material.color.b + 20);
        }

        Debug.Log("Shader");
        highlighted = true;
    }

    public static void UndoHighlight()
    {
        // Debug.Log("UNDO SHADER");
        if (highlighted)
        {
            foreach (Material material in renderer.materials)
            {
                material.color = new Color(material.color.r, material.color.g, material.color.b - 20);

            }
        }

        highlighted = false;

    }
}
