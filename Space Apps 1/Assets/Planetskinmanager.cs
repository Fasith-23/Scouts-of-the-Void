using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Planetskinmanager : MonoBehaviour
{
  private int index;
      public sceneloader sl;
      public GameObject[] characterList;
      Scene currentScene;
      string SceneName;
      void Start(){
        currentScene=SceneManager.GetActiveScene();
        SceneName =currentScene.name;
        index = PlayerPrefs.GetInt("skinIndex2");
        characterList = new GameObject[6];
        for(int i=0; i<6; i++){
          characterList[i]= transform.GetChild(i).gameObject;
        }
        foreach(GameObject go in characterList){
          go.SetActive(false);
          if(SceneName=="Planet selection"){
            foreach(GameObject GO in characterList){
              GO.SetActive(true);
            }
          }
        if(characterList[index]){
          characterList[index].SetActive(true);
          Debug.Log(index);
        }
      }
    }
      public void Select(int index2){
        PlayerPrefs.SetInt("skinIndex2", index2);
        sl.LoadNextLevel();
      }
}
