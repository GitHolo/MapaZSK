using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class date : MonoBehaviour
{
    public TMP_Text czas;
    void Start()
    {
        czas = GetComponent<TextMeshProUGUI>();
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("dd MM yyyy");
        print(time);
        czas.text = time;
    }

}
