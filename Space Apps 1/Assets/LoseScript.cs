using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseScript : MonoBehaviour
{
    public PlayerMovement PM;
    public GameObject Obstacles;
    public Rigidbody Playerrb;
    public Text Txt;
    public Text TxtByFuel;
    public Button losebtn;
    public Button losebtn2;
    public GameObject canvas;
    public AudioSource crash;
    public AudioSource losing;

    public bool lost= false;
    bool LostByFuel = false;
    public void Lose(){
      if(!LostByFuel){
        crash.time=0.9f;
        crash.Play(0);
        losing.Play(1);
        PM.enabled = false;
        Playerrb.velocity = new Vector3(0, 0, 0);
        Playerrb.angularVelocity = new Vector3(0,0,0);
        Txt.enabled = true;
        lost = true;
        losebtn.gameObject.SetActive(true);
        losebtn2.gameObject.SetActive(true);
        canvas.SetActive(false);
      }
    }
    public void LoseByFuel(){
      if(!lost){
        PM.enabled = false;
        Playerrb.velocity = new Vector3(0, 0, 0);
        TxtByFuel.enabled = true;
        LostByFuel = true;
        losebtn.gameObject.SetActive(true);
        losebtn2.gameObject.SetActive(true);
        canvas.SetActive(false);
        losing.Play(1);
      }

    }

    void OnCollisionEnter(Collision collision){
      Invoke("Lose", 0.1f);
    }
}
