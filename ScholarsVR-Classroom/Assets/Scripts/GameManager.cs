using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool profStartedTalking = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Prof.IsPlaying())
        {
            profStartedTalking = true;
        }

        SceneTransition();
    }

    void SetUp()
    {
        // setup things
        // call this function in Start()
    }

    void SceneTransition()
    {
        if (profStartedTalking && !Prof.IsPlaying())
        {
            SceneManager.LoadScene("Question", LoadSceneMode.Single);
        }
    }

    void PencilClick()
    {
        // call this from Controller
        // do things:
        //   pencil talks, etc
    }

    void EraserClick()
    {
        // call this from Controller
        // do things:
        //   eraser talks, etc
    }

    void TalkingStudentClick()
    {
        // call this from Controller
        // do things:
        //   student talks, etc
    }

    void FakeProfClick()
    {
        // call this from Controller
        // do things:
        //   fakeprof talks, etc
    }

    void RaccoonClick()
    {
        // call this from Controller
        // do things:
        //   raccoon talks, etc
    }

    void CatClick()
    {
        // call this from Controller
        // do things:
        //   cat talks, etc
    }
}
