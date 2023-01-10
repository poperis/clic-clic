using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menucontrol : MonoBehaviour
{
    public void Load()
    {
        SceneManager.LoadScene("Gameview");
    }
    public void New()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Gameview");
    }
    public void Quit()
    {
       Application.Quit();
    }
}
