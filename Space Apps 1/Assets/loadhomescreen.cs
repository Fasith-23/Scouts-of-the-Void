using UnityEngine;
using UnityEngine.SceneManagement;

public class loadhomescreen : MonoBehaviour
{
    public float time = 2.0f;
    public void Start()
    {
        Invoke("Loadnextlevel", time);
    }
    public void Loadnextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
