using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAnswer> QnA;
    public GameObject[] options;
    public AudioSource crctans;
    public int currentQ;
    public sceneloader sl;
    public Text Qtext;
    public Radiationvanish radvan;
    public shieldcraft shieldcft;
    public GameObject popupbox;
    public GameObject winquiz;

    private void Start()
    {
        winquiz.active = false;
        generateQuestion();
    }
    public void correct()
    {
        QnA.RemoveAt(currentQ);
        generateQuestion();
        crctans.time=0.8f;
        crctans.Play(0);
    }
    public void wrong()
    {
        SceneManager.LoadScene("QuizWrongAns", LoadSceneMode.Single);
    }
    void SetAnswers()
    {
        for(int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQ].Answers[i];

            if(QnA[currentQ].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect =true;
            }
        }
    }
    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQ = Random.Range(0, QnA.Count);
            Qtext.text = QnA[currentQ].Question;
            SetAnswers();
        }
        else
        {
            radvan.radiationvanish();
            shieldcft.shield();
            popupbox.active = false;
            for (int i = 0; i < options.Length; i++)
            {
                options[i].active = false;
            }
            winquiz.active = true;
            Debug.Log("out of qs");
            Invoke("toPlanet", 3.0f);
        }

    }

    void toPlanet(){
      sl.LoadNextLevel();
    }
}
