using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class skinmanager : MonoBehaviour
{   private int index;
    public sceneloader sl;
    public GameObject[] characterList;
    Scene currentScene;
    string SceneName;
    void Start(){
      currentScene=SceneManager.GetActiveScene();
      SceneName =currentScene.name;
      index = PlayerPrefs.GetInt("skinIndex");
      characterList = new GameObject[3];
      for(int i=0; i<3; i++){
        characterList[i]= transform.GetChild(i).gameObject;
      }
      foreach(GameObject go in characterList){
        go.SetActive(false);
        if(SceneName=="Skin Selection"){
          foreach(GameObject GO in characterList){
            GO.SetActive(false);
          }
        }
      if(characterList[index])
        characterList[index].SetActive(true);
    }
  }
    public void Select(int index){
      PlayerPrefs.SetInt("skinIndex", index);
      sl.LoadNextLevel();
    }
}
