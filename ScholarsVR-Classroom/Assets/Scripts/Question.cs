using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : ScriptableObject
{
    public string body = "";
    public string optionA = "";
    public string optionB = "";
    public string optionC = "";
    public string optionD = "";
    public int correctAnswer = 0;

    public Question(string body, string optionA, string optionB, 
                    string optionC, string optionD, int correctAnswer)
    {
        this.body = body;
        this.optionA = optionA;
        this.optionB = optionB;
        this.optionC = optionC;
        this.optionD = optionD;
        this.correctAnswer = correctAnswer;
    }
}