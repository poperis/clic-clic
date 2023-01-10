using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public static int total;
    public static int multiplier;
    public static int numberofprestiges;
    public static int amount;

    void Start()
    {
        total = PlayerPrefs.GetInt("total", 0);
        multiplier = PlayerPrefs.GetInt("multiplier", 1);
        numberofprestiges = PlayerPrefs.GetInt("numberofprestiges", 0);
        amount = PlayerPrefs.GetInt("amount", 1000000);
    }
   
}
