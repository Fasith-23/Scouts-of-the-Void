using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class foldervideo : MonoBehaviour
{
    public VideoPlayer Video;
    public Button contbtn;
    public sceneloader sl;
    public float pausetime;
    public float nextscenetime;
    void pause(){
      Video.Pause();
      contbtn.gameObject.SetActive(true);
    }
    void Start()
    {
        Invoke("pause", pausetime);
    }
    void Nextlevel(){
      sl.LoadNextLevel();
    }
    void nextScene(){
      SceneManager.LoadSceneAsync("Level01");
    }
    public void play(){
      Video.Play();
      contbtn.gameObject.SetActive(false);
      Invoke("Nextlevel", nextscenetime);
    }
}
