using UnityEngine;
using UnityEngine.UI;

public class QuestionClick : MonoBehaviour
{

    public OVRInput.Controller right_controller;
    public OVRInput.Controller left_controller;
    bool right_press = false;
    bool left_press = false;
    public GameObject controller;
    bool click;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        OVRInput.FixedUpdate();
        right_press = OVRInput.Get(OVRInput.RawButton.RIndexTrigger);
        left_press = OVRInput.Get(OVRInput.RawButton.LIndexTrigger);
        click = (right_press || left_press);
        
        RaycastHit hit;

        if (Physics.Raycast(controller.transform.position, controller.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            HandleClick(hit, click);
        }
    }

    private void HandleClick(RaycastHit hit, bool click)
    {
        if (hit.collider.CompareTag("ButtonA"))
        {
            if (click)
            {
                GameObject.Find("ButtonA").GetComponent<Button>().onClick.Invoke();
            }
        }
        if (hit.collider.CompareTag("ButtonB"))
        {
            if (click)
            {
                GameObject.Find("ButtonB").GetComponent<Button>().onClick.Invoke();
            }
        }
        if (hit.collider.CompareTag("ButtonC"))
        {
            if (click)
            {
                GameObject.Find("ButtonC").GetComponent<Button>().onClick.Invoke();
            }
        }
        if (hit.collider.CompareTag("ButtonD"))
        {
            if (click)
            {
                GameObject.Find("ButtonD").GetComponent<Button>().onClick.Invoke();
            }
        }
    }
}