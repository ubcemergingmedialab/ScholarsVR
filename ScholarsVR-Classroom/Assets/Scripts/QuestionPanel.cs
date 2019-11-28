/// <summary>
/// A question panel that can display a multiple-choice question
/// with 4 choices
/// </summary>

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

    /// <summary>
    /// create a new question, and display it
    /// <summary>
    private void Start()
    {
        answerCorrect = false;

        question = (Question) ScriptableObject.CreateInstance("Question");

        // Change here to change the question
        // "Question body"
        // "Option A"
        // "Option B"
        // "Option C"
        // "Option D"
        // Correct answer, 0 = A, 1 = B, 2 = C, 3 = D
        question.setQuestion("Hi, this is a question, the third option is correct", 
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

    /// <summary>
    /// Called when option A is clicked
    /// If correct, disable the buttons, increase score
    /// </summary>
    public void SelectA() {
        if (!answerCorrect) {
            if (question.correctAnswer == 0) {
                answerCorrect = true;
                DisableButtons();
                score++;
            } else {
                // Code to run when the answer is not correct
            }
        }
    }

    /// <summary>
    /// Called when option B is clicked
    /// If correct, disable the buttons, increase score
    /// </summary>
    public void SelectB() {
        if (!answerCorrect) {
            if (question.correctAnswer == 1) {
                answerCorrect = true;
                DisableButtons();
                score++;
            } else {
                // Code to run when the answer is not correct
            }
        }
    }

    /// <summary>
    /// Called when option C is clicked
    /// If correct, disable the buttons, increase score
    /// </summary>
    public void SelectC() {
        if (!answerCorrect) {
            if (question.correctAnswer == 2) {
                answerCorrect = true;
                DisableButtons();
                score++;
            } else {
                // Code to run when the answer is not correct
            }
        }
    }

    /// <summary>
    /// Called when option D is clicked
    /// If correct, disable the buttons, increase score
    /// </summary>
    public void SelectD() {
        if (!answerCorrect) {
            if (question.correctAnswer == 3) {
                answerCorrect = true;
                DisableButtons();
                score++;
            } else {
                // Code to run when the answer is not correct
            }
        }
    }

    /// <summary>
    /// Set colors for buttons when they are disabled,
    /// based on the correct answer
    /// </summary>
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
    
    /// <summary>
    /// Disable buttons
    /// </summary>
    private void DisableButtons() 
    {
        buttonA.interactable = false;
        buttonB.interactable = false;
        buttonC.interactable = false;
        buttonD.interactable = false;
    }

    /// <summary>
    /// Enable all the buttons
    /// Not used in test scene, but can be useful
    /// </summary>
    public void resetButtons() 
    {
        buttonA.interactable = true;
        buttonB.interactable = true;
        buttonC.interactable = true;
        buttonD.interactable = true;
    }
}
