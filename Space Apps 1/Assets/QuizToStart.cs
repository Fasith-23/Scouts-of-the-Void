using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizToStart : MonoBehaviour
{
   public void quiztostart()
    {
        SceneManager.LoadScene("Planet selection", LoadSceneMode.Single);
    }
}
