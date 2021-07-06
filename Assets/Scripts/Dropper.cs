using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    private void Update()
    {
        if(Time.time > 3)
        {
            Debug.Log("3 seconds have elapsed");
        }
    }
}