using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldcraft : MonoBehaviour
{
    public void Start()
    {
        gameObject.active = false;
    }
    public void shield()
    {
        gameObject.active = true;
    }
}
