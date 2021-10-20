using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class videoplaying : MonoBehaviour
{   public VideoPlayer video;
    public sceneloader sl;
    public Button btn;
    public bool cont;
    int i;
    public void play(){
      video.Play();
      btn.interactable = false;
      cont = true;
      i++;
      if(i==6){
        sl.LoadNextLevel();
      }
    }
}
