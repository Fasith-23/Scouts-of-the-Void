using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserScript : MonoBehaviour
{
    public Rigidbody ship;
    public Rigidbody laser;
    public GameObject Laser;
    public Image laserimg;
    public AudioSource shooting;
    int cooldown=0;
    public void Shoot(){
      Laser.SetActive(true);
      Vector3 offset = new Vector3(0, 0, -15);
      laser.position = ship.position + offset;
      laser.velocity = new Vector3(0, 0, ship.velocity.z -300);
      laserimg.enabled = false;
      shooting.time =1.3f;
      shooting.Play(0);
    }
    void Cooldownreset(){
      cooldown=0;
      laserimg.enabled = true;
    }
    void Update(){

      if(Input.GetKey("space")&&(cooldown==0)){
        Shoot();
        cooldown=5;
        Invoke("Cooldownreset", 4f);
      }
    }
}
