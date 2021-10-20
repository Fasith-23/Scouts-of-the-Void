using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Planetselection : MonoBehaviour
{
  public void gotoplanet()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }   
 
}
