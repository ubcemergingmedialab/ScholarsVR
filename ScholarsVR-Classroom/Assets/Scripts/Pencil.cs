using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pencil : MonoBehaviour
{
    Rigidbody rb;
    bool animationBack = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Pencil Script");
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if (animationBack)
       {
            transform.Rotate(10 * Time.deltaTime, 10 * Time.deltaTime, 10 * Time.deltaTime);
            animationBack = false;
       } else
       {
            transform.Rotate(-10, -10, -10);
            animationBack = true;
        }
    }
}
