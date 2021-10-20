using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public GameObject[] quizManager;
    public int i = 0;
    public void Answer()
    {
        for (i = 0;i<6; i++)
        {
            if (isCorrect&& quizManager[i].activeSelf)
            {
                Debug.Log("CorrectAnswer");

                quizManager[i].GetComponent<QuizManager>().correct();
            }
            else if(quizManager[i].activeSelf)
            {
                Debug.Log("WrongAnswer");
                quizManager[i].GetComponent<QuizManager>().wrong();
            }
        }
    }
}
