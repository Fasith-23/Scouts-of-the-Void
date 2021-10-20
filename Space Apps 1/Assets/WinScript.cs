using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
  public Rigidbody playerrb;
  public Text txt;
  public PlayerMovement pm;
  public FollowPlayer fp;
  public Button winbtn;
  public GameObject canvas;
  public AudioSource winning;
  int secretwin=0;
  int flag=0;
    void Win(){
      winning.Play(0);
      txt.enabled = true;
      pm.enabled = false;
      fp.enabled = false;
      playerrb.velocity = new Vector3(0, 0, -5);
      winbtn.gameObject.SetActive(true);
      canvas.SetActive(false);
    }
    void Update(){

      if(playerrb.position.z <-9000f&&flag==0){
        flag=1;
        Invoke("Win", 0.1f);
      }
      if(Input.GetKeyDown("p")){
        secretwin++;
        if(secretwin==5){
          Invoke("Win", 0.1f);
        }
      }
    }
}
