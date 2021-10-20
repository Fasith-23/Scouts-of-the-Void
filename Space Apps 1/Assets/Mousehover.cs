using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Mousehover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text texthover;

    public void OnPointerEnter(PointerEventData eventData)
    {
        texthover.enabled = true;
        
    }
    public void OnPointerExit(PointerEventData eventData){
      texthover.enabled = false;
    }
}
