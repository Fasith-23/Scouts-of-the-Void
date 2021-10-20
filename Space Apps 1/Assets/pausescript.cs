using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class pausescript : MonoBehaviour
{
    public VideoPlayer comic;
    videoplaying vid;
    public GameObject go;
    public Button Btn;
    void Start(){
      vid = go.GetComponent<videoplaying>();
      vid.cont = true;
    }
    void pause(){
      comic.Pause();
      Btn.interactable = true;

    }
    void Update()
    {
        if(vid.cont){
          vid.cont= false;
          Invoke("pause", 2.0f);
        }
    }
}
