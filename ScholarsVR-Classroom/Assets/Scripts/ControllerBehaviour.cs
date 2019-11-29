using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerBehaviour : MonoBehaviour
{

    public OVRInput.Controller right_controller;
    public OVRInput.Controller left_controller;
    bool right_press_2 = false;
    bool left_press_2 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        OVRInput.FixedUpdate();

        right_press_2 = OVRInput.Get(OVRInput.RawButton.RIndexTrigger);
        left_press_2 = OVRInput.Get(OVRInput.RawButton.LIndexTrigger);

        RaycastHit hit;

        if (Physics.Raycast(gameObject.transform.position, gameObject.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.collider.CompareTag("Prof"))
            {
                if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
                {
                    Debug.Log("Right Click Prof - B");
                    SceneManager.LoadScene("Pencil-Talk-20191113", LoadSceneMode.Single);
                }
            }
        }
    }
}