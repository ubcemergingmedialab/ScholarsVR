/// <summary>
/// A count down timer
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour {

    public double time_sec;
    private bool running;
    private Text timer;

    void Start () {
        running = false;
        timer = GetComponent<Text> ();
    }



    private void FixedUpdate() {
        if (time_sec > 0 && running) {
        
            if ((time_sec - Time.fixedDeltaTime <= (int) time_sec)) {
                onSecond();
            }

            time_sec = time_sec - Time.fixedDeltaTime;
            //time_sec = Math.Round(time_sec, 2);
        }

        if (time_sec <= Double.Epsilon && running) {
            atFinish();
            running = false;
        }
    }

    /// <summary>
    /// Start the timer for the first time or a paused state
    /// </summary>   
    public void startTimer() {
        running = true;
    }


    /// <summary>
    /// Pause the timer
    /// </Summary>
    public void pauseTimer() {
        running = false;
    }


    /// <summary>
    /// The function called when the timer reaches 0
    /// </summary>
    private void atFinish() {
        timer.text = "End";
    }


    /// <summary>
    /// The function called once every second
    /// </summary>
    private void onSecond() {
        timer.text = ((int) time_sec).ToString();
    }

}
