using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class camChange : MonoBehaviour
{
    [SerializeField] private Transform cam;

    public void DropdownSample(int index)
    {
        switch (index)
        {
            case 0: cam.position = new Vector3(929, 526, 0);break;
            case 1: cam.position = new Vector3(3473, 526, 0);break;
            case 2: cam.position = new Vector3(929, -1004, 0); break;
            case 3: cam.position = new Vector3(3473,-1004,0); break;
            case 4: cam.position = new Vector3(6017,-1004,0); break;
            case 5: cam.position = new Vector3(6017, 526, 0); break;
        }
    }
}
