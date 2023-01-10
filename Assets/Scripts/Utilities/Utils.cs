using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Utils : MonoBehaviour
{
    public Text reqr;



    public void Update()
    {
        reqr.text = "To next prestige: " + Variables.amount;
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
       /* if (Input.GetKeyDown(KeyCode.M))
         {
            Variables.total = 999999;
             PlayerPrefs.SetInt("total", Variables.total);
            Variables.numberofprestiges = 99999;
             PlayerPrefs.SetInt("numberofprestiges", Variables.numberofprestiges);
            Variables.multiplier += 1000000;
             PlayerPrefs.SetInt("multiplier", Variables.multiplier);
            Variables.amount = 1000000 + 1000000 * Variables.numberofprestiges;
             PlayerPrefs.SetInt("amount", Variables.amount);


         }*/
    }
    public void Redo()
    {
        PlayerPrefs.DeleteAll();
    }
}
