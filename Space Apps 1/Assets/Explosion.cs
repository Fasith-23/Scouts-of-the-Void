using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject Ship;

    LoseScript losing;
    int u, v, w;
    void Start(){
      losing = Ship.GetComponent<LoseScript>();
      u = Random.Range(-5, 5);
      v = Random.Range(-5,5);
      w = Random.Range(-5,5);
    }
    // Update is called once per frame
    void Update()
    {
        if(losing.lost){
          transform.position =new Vector3(transform.position.x +(u*Time.deltaTime), transform.position.y +(v*Time.deltaTime), transform.position.z + (Time.deltaTime*w));
        }
    }
}
