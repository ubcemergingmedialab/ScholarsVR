using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PingPongScale : MonoBehaviour
{
    public float scale;
    public string dimension_one;
    public string dimension_two;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (string.Equals(dimension_one, "x") || string.Equals(dimension_two, "x"))
        {
            transform.localScale = new Vector3(Mathf.PingPong(Time.time, scale), transform.localScale.y, transform.localScale.z);
        }

        if (string.Equals(dimension_one, "y") || string.Equals(dimension_two, "y"))
        {
            transform.localScale = new Vector3(transform.localScale.x, Mathf.PingPong(Time.time, scale), transform.localScale.z);
        }

        if (string.Equals(dimension_one, "z") || string.Equals(dimension_two, "z"))
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, Mathf.PingPong(Time.time, scale));
        }
    }
}
