using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInteractionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit raycastHit;
        GameObject gameObject = null;
        if (Physics.Raycast(transform.position, transform.forward, out raycastHit))
        {
            gameObject = raycastHit.collider.gameObject;

            if (gameObject.CompareTag("Prof"))
            {
                Debug.Log("Hit Prof");
            }
        }
    }
}
