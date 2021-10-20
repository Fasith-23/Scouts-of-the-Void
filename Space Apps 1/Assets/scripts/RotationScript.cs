using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        Vector3 temp = transform.eulerAngles;
        temp.y = transform.eulerAngles.y +3;
        transform.eulerAngles= temp;
    }


}
