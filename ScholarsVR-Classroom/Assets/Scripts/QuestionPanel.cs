using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionPanel : MonoBehaviour
{
    private Question question;
    private bool answerCorrect;    

    public int score = 0;
    public Text body;
    public Text optionA;
    public Text optionB;
    public Text optionC;
    public Text optionD;

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public Button buttonD;

    private void Start()
    {
        answerCorrect = false;

        question = 
            new Question("Hi, this is a question, the third option is correct", 
                        "Here is the first option", 
                        "Here is the second option", 
                        "Here is the third option", 
                        "Here is the fourth option", 
                        2);
        
        body.text = question.body;
        optionA.text = question.optionA;
        optionB.text = question.optionB;
        optionC.text = question.optionC;
        optionD.text = question.optionD;

        SetDisabledColor();
    }

    public void SelectA() {
        if (!answerCorrect) {
            if (question.correctAnswer == 0) {
                answerCorrect = true;
                DisableButtons();
                score++;
            }
        }
    }

    public void SelectB() {
        if (!answerCorrect) {
            if (question.correctAnswer == 1) {
                answerCorrect = true;
                DisableButtons();
                score++;
            }
        }
    }

    public void SelectC() {
        if (!answerCorrect) {
            if (question.correctAnswer == 2) {
                answerCorrect = true;
                DisableButtons();
                score++;
            }
        }
    }

    public void SelectD() {
        if (!answerCorrect) {
            if (question.correctAnswer == 3) {
                answerCorrect = true;
                DisableButtons();
                score++;
            }
        }
    }

    private void SetDisabledColor()
    {   
        ColorBlock colors = buttonA.colors;
        colors.disabledColor = question.correctAnswer == 0 ? Color.green : Color.red;    
        buttonA.colors = colors;

        colors = buttonB.colors;
        colors.disabledColor = question.correctAnswer == 1 ? Color.green : Color.red;    
        buttonB.colors = colors; 

        colors = buttonC.colors;
        colors.disabledColor = question.correctAnswer == 2 ? Color.green : Color.red;    
        buttonC.colors = colors; 

        colors = buttonD.colors;
        colors.disabledColor = question.correctAnswer == 3 ? Color.green : Color.red;    
        buttonD.colors = colors;  
    }

    private void DisableButtons() 
    {
        buttonA.interactable = false;
        buttonB.interactable = false;
        buttonC.interactable = false;
        buttonD.interactable = false;
    }

    public void resetButtons() 
    {
        buttonA.interactable = true;
        buttonB.interactable = true;
        buttonC.interactable = true;
        buttonD.interactable = true;
    }
}
