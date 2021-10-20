using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageSelection : MonoBehaviour
{
  private int index;
      
      public GameObject[] characterList;
      string SceneName;
      void Start(){
        index = PlayerPrefs.GetInt("skinIndex");
        characterList = new GameObject[7];
        for(int i=0; i<7; i++){
          characterList[i]= transform.GetChild(i).gameObject;
        }
        foreach(GameObject go in characterList){
          go.SetActive(false);

          }
        if(characterList[index]){
          characterList[0].SetActive(true);
        }
      }
      public void Selectnext(){
        index++;
        if(index==7){
          index= 0;
        }
        PlayerPrefs.SetInt("skinIndex", index);
        foreach(GameObject go in characterList){
          go.SetActive(false);

          }
        if(characterList[index])
          characterList[index].SetActive(true);
      }
      public void Selectprev(){
        index--;
        if(index<0){
          index= 6;
        }
        PlayerPrefs.SetInt("skinIndex", index);
        foreach(GameObject go in characterList){
          go.SetActive(false);

          }
        if(characterList[index])
          characterList[index].SetActive(true);
      }
}
