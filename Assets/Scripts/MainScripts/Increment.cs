using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Increment : MonoBehaviour
{
    public Text scoreText;
   /*void Start()
    {
        
            InvokeRepeating("addScore", 1.0f, (float)Variables.multiplier * 1.0f);
            PlayerPrefs.SetInt("total", Variables.total);
        
            
        
          
           

        
      
    }*/
    public void addScore()
    {
        
        Variables.total += Variables.multiplier ;
        PlayerPrefs.SetInt("total", Variables.total);
        
       
    }
    void Update()
    {
       
        scoreText.text = "CLICKS: " + Variables.total;
        if (Variables.total >= 1000)
        {
            scoreText.text = "CLICKS: " + (Variables.total / 1000) + " K";
        }
        if(Variables.total >= 1000000)
        {
            scoreText.text = "CLICKS: " + (Variables.total / 1000000) + " M";
        }
        if (Variables.total >= 1000000000)
        {
            scoreText.text = "CLICKS: " + (Variables.total / 1000000000) + " B";
        }
        if (Variables.total > 2000000000)
        {

            Variables.total = 2000000000;

        }
    }

}
