
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce =400f;
    public float sideforce = 500f;
    public float updownforce = 500f;
    private float minx, miny, maxx, maxy;
  /*  public void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetUpBoundaries();
    }*/

    void FixedUpdate()
    {
        if(rb.velocity.z>=-250f){
          rb.AddForce(0,0,-forwardforce * Time.deltaTime);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0,updownforce * Time.deltaTime, 0);
        }
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0,-updownforce * Time.deltaTime, 0);
        }
        Vector3 maxlimit = rb.transform.position;
        if (maxlimit.x> 13.5 && maxlimit.y < 10.5 && maxlimit.y > -4.5)
        {
            rb.transform.position = new Vector3(13.5f, maxlimit.y, maxlimit.z);
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
        }
        if (maxlimit.x<-13.5 && maxlimit.y < 10.5 && maxlimit.y > -4.5)
        {
            rb.transform.position = new Vector3(-13.5f, maxlimit.y, maxlimit.z);
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
        }
        if (maxlimit.y>10.5 && maxlimit.x < 13.5 && maxlimit.x > -13.5)
        {
            rb.transform.position = new Vector3(maxlimit.x, 10.5f, maxlimit.z);
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        }
        if (maxlimit.y<-4.5 && maxlimit.x<13.5 && maxlimit.x>-13.5)
        {
            rb.transform.position = new Vector3(maxlimit.x, -4.5f, maxlimit.z);
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        }
        if (maxlimit.y<=-4.5 && maxlimit.x>=13.5)
        {
            rb.transform.position = new Vector3(13.5f, -4.5f, maxlimit.z);
            rb.velocity = new Vector3(0, 0, rb.velocity.z);
        }
        if (maxlimit.y>=10.5 && maxlimit.x>=13.5)
        {
            rb.transform.position = new Vector3(13.5f, 10.5f, maxlimit.z);
            rb.velocity = new Vector3(0,0, rb.velocity.z);
        }
        if (maxlimit.y<=-4.5 && maxlimit.x<=-13.5)
        {
            rb.transform.position = new Vector3(-13.5f, -4.5f, maxlimit.z);
            rb.velocity = new Vector3(0,0, rb.velocity.z);
        }
        if (maxlimit.y>=10.5 && maxlimit.x<=-13.5)
        {
            rb.transform.position = new Vector3(-13.5f, 10.5f, maxlimit.z);
            rb.velocity = new Vector3(0,0, rb.velocity.z);
        }


    }

}
