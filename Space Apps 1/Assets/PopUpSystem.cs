using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpSystem : MonoBehaviour
{
    public GameObject pub;
    public Animator animator;
    public TMP_Text popuptext;
     
    public void PopUp(string text)
    {
        pub.SetActive(true);
        popuptext.text = text;
        animator.SetTrigger("pop");
    }
}
