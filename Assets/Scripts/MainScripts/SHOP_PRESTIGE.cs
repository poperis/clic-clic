using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SHOP_PRESTIGE : MonoBehaviour
{
    public Text count;
    

    public void Shoppin()
    {
        SceneManager.LoadScene("Shop");
    }
    public void Prestigin()
    {
        if (Variables.total >= Variables.amount /*&& Variables.multiplier >= 10000*/)
        {
            Variables.total = 0;
            PlayerPrefs.SetInt("total", Variables.total);
            Variables.numberofprestiges += 1;
            PlayerPrefs.SetInt("numberofprestiges", Variables.numberofprestiges);
            Variables.multiplier = Variables.numberofprestiges * 2;
            PlayerPrefs.SetInt("multiplier", Variables.multiplier);
            Variables.amount = 1000000 + 1000000 * Variables.numberofprestiges;
            PlayerPrefs.SetInt("amount", Variables.amount);

        }
           
               
               
            
            
           

        }
    public void Update()
    {
        count.text = "Prestige: " + Variables.numberofprestiges;
       
        if (Variables.numberofprestiges == 1000)
        {
            count.text = "You've reached MAX prestige!";
            

        }
        if (Variables.numberofprestiges > 1000)
        {
            PlayerPrefs.DeleteAll();

        }
    }
}
   



