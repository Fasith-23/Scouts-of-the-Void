using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelEnd : MonoBehaviour
{
    public void Win(){
      SceneManager.LoadSceneAsync("Home Screen");
    }
    public void Lose(){
      SceneManager.LoadSceneAsync("Home Screen");
    }
}
