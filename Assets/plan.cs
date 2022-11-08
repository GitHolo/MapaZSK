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
        print(time);
        RectTransformExtensions.SetTop(rt,time);
        RectTransformExtensions.SetBottom(rt, time + 6);
    }
}
