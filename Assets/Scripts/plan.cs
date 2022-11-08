using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plan : MonoBehaviour
{
    RectTransform rt;
    void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        string hour = System.DateTime.UtcNow.ToLocalTime().ToString("HH");
        string min = System.DateTime.UtcNow.ToLocalTime().ToString("mm");
        int hourInt = int.Parse(hour);
        int minInt = int.Parse(min);
        hourInt = hourInt * 60;
        int time = hourInt + minInt-465;
        int botTime = 654 - time;
        print(time);
        if(time>0)
        {
            RectTransformExtensions.SetTop(rt,time);
        }
        else
        {
            RectTransformExtensions.SetTop(rt, 0);
        }
        if(botTime>0)
        {
            RectTransformExtensions.SetBottom(rt, botTime);
        }
        else
        {
            RectTransformExtensions.SetBottom(rt, 0);
        }
    }
}