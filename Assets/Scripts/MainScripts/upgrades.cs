using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgrades : MonoBehaviour
{
    public int totalam;
    private int multiinc;
    public void Buy(int totalam)
    {
        if(Variables.total >= totalam)
        {
            multiinc = totalam / 25;
            Variables.multiplier += multiinc;
            Variables.total -= totalam;
        }
        if(Variables.total < 0)
        {
            Variables.total = 0;
        }
        PlayerPrefs.SetInt("total", Variables.total);
        PlayerPrefs.SetInt("multiplier", Variables.multiplier);
    }

   
}
