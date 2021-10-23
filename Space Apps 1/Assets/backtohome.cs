using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class backtohome : MonoBehaviour
{
    public VideoPlayer video;
    public Button btn;

    public float pausetime = 5f;
    void Start()
    {
        Invoke("pause", pausetime);
    }
    public void pause()
    {
        video.Pause();
        btn.gameObject.SetActive(true);
    }
}
