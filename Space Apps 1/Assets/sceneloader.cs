using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{

    public Animator transition;
    public float waittime = 1f;
    public bool SceneTransitioner;
    void Start(){
      SceneTransitioner = false;
    }
    public void Update()
    {
        if (SceneTransitioner)
        {
            LoadNextLevel();
        }
    }
    public void Restart(){
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex));
    }
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1));
    }
    public void LoadHome()
    {
        StartCoroutine(LoadLevel(1));
    }
    public void LoadQuiz(){
      StartCoroutine(LoadLevel(10));
    }
    public void LoadPS(){
      StartCoroutine(LoadLevel(3));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(waittime);

        SceneManager.LoadScene(levelIndex);
    }
}
