using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class time : MonoBehaviour
{
    private TMP_Text czas;
    void Start()
    {
        czas = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm:ss");
        print(time);
        czas.text = time;
    }

}
