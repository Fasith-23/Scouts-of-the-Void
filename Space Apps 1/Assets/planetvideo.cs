using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class planetvideo : MonoBehaviour
{
  public VideoPlayer Video;
  public VideoPlayer Video1;
  public VideoPlayer Video2;
  public VideoPlayer Video3;
  public VideoPlayer Video4;
  public VideoPlayer Video5;
  public Button contbtn;
  public sceneloader sl;
  public float pausetime;
  public float nextscenetime;
  void pause(){
    Video.Pause();
    Video1.Pause();
    Video2.Pause();
    Video3.Pause();
    Video4.Pause();
    Video5.Pause();
    contbtn.gameObject.SetActive(true);
  }
  void Start()
  {
    Invoke("pause", pausetime);
  }
  void Nextlevel(){
    if(SceneManager.GetActiveScene().buildIndex!=10){
      sl.LoadNextLevel();
    }
    if(SceneManager.GetActiveScene().buildIndex == 10){
      sl.LoadHome();
    }
  }

  public void play(){
    Video.Play();
    Video1.Play();
    Video2.Play();
    Video3.Play();
    Video4.Play();
    Video5.Play();
    contbtn.gameObject.SetActive(false);
    Invoke("Nextlevel", nextscenetime);
  }
}
