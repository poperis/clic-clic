using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class back : MonoBehaviour
{
   public void Bck()
    {
        SceneManager.LoadScene ("Gameview");
    }
}
