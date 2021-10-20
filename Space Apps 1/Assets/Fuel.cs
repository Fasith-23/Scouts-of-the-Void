using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fuel : MonoBehaviour
{
    public Image fuel;
    public LoseScript lose;
    float height=500f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")|| Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey("a")|| Input.GetKey("s")|| Input.GetKey("d")|| Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.RightArrow)){
          height = height - 0.7f;
          fuel.rectTransform.sizeDelta = new Vector2(400, height);
          fuel.rectTransform.position = new Vector3(fuel.rectTransform.position.x, fuel.rectTransform.position.y -0.5f, 0);
        }
        if(fuel.rectTransform.sizeDelta.y == 0){
          lose.LoseByFuel();
        }
    }
}
