using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Achievement : MonoBehaviour
{
    public Text lck1;
    public Text lck2;
    public Text lck3;
    public Text lck4;
    public Text lck5;
    


    public void Ach()
    {
        SceneManager.LoadScene("achievements");
    }

    void Update()
    {
        if(Variables.multiplier >= 1000000)
        {
          lck1.text = "Unlocked";
            
        }
        if (Variables.numberofprestiges >= 1000)
        {
            lck2.text = "Unlocked";
        }
        if (Variables.total >= 1000000000)
        {

           lck3.text = "Unlocked";
        }
        if (Variables.multiplier >= 1000000 && Variables.numberofprestiges >= 1000 && Variables.total >= 1000000000)
        {

            lck4.text = "Unlocked";
            
        }
        if (Variables.numberofprestiges >= 10)
        {
            lck5.text = "Unlocked";
        }
        if (Variables.numberofprestiges >= 10)
        {
            lck5.text = "Unlocked";
        }
    }
}
