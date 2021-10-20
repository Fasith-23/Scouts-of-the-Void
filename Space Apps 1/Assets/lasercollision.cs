using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lasercollision : MonoBehaviour
{   public GameObject laser;
    public bool shoot;
    void Start(){
      shoot=false;
    }
    void OnCollisionEnter(){
        laser.SetActive(false);
        shoot=true;
      }
}
