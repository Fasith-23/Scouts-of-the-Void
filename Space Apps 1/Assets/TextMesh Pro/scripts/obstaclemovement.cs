using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclemovement : MonoBehaviour
{
    public Rigidbody rb;
    float backforce = 410f;
  public void Start()
    {
      Vector3 p = rb.velocity;
      rb.velocity = new Vector3(p.x, p.y, p.z -30f);
    }
    void Update()
    {

    rb.AddForce(0, 0, -backforce * Time.deltaTime);
    }
    /*void moveobs()
    {
       float cx = gameObject.transform.position.x;
       float cy = gameObject.transform.position.y;
        float nx = cx + Random.Range(cx - sf, cx + sf);
        float ny = cy + Random.Range(cy - sf, cy + sf);
        NewPos = new Vector3(nx, ny, gameObject.transform.position.z);
        transform.position = NewPos;
    }*/
}
