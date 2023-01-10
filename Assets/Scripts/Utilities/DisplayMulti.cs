using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayMulti : MonoBehaviour
{

    public Text multi;
    // Update is called once per frame
    void Update()
    {
        multi.text = "+" + Variables.multiplier + " / click";
    }
}
