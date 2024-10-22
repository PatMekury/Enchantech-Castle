using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionReset : MonoBehaviour
{
    public GameObject question1;
    public GameObject true1;
    public GameObject false1;
    public GameObject stairGate;
    public GameObject[] otherAnswers;
    public GameObject[] otherQuestions;

    public void ResetQuestions()
    {
        if (stairGate.activeSelf){
        
            question1.SetActive(true);
            true1.SetActive(true);
            false1.SetActive(true);
            foreach (GameObject answers in otherAnswers)
            {
                answers.SetActive(false);
            }
            foreach (GameObject questions in otherQuestions)
            {
                questions.SetActive(false);
            }
        }

    }
}
