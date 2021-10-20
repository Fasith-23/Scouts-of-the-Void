using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadplanet : MonoBehaviour
{
   public void loadPlanet()
    {
        SceneManager.LoadScene("PlanetInfo");
    }
}
