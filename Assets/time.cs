using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Globalization;
using System;

public class time : MonoBehaviour
{
    TextMeshPro textpro = GetComponent<TextMeshPro>(); 
    public static void Main()
    {
        DateTime date = DateTime.Now;
        string[] cultureNames = { "pl_PL" };
        foreach (var cultureName in cultureNames)
        {
            var culture = new CultureInfo(cultureName);
            textpro.SetText("{0}, {1:G}", date.ToString(culture), date.Kind);
        }
    }
}
