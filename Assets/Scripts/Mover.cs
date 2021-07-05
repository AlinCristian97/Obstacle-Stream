using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _xValue = 0f;
    private float _yValue = 0.01f;
    private float _zValue = 0;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.Translate(_xValue, _yValue, _zValue);
    }
}
