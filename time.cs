using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public Text TextTime;
    float GameSecond;
    int k;
    float GameMinutes;
    string stringSecond;
    string stringMinutes;

    void Update()
    {
        GameSecond += Time.deltaTime;
        k = (int)GameSecond;
        if (GameSecond > 59)
        {
            GameSecond -= 60;
            GameMinutes += 1;
        }
        stringSecond = k.ToString();
        stringMinutes = GameMinutes.ToString();
        //TextTime.text = "TIME " + stringMinutes + " : " + stringSecond;
    }
}