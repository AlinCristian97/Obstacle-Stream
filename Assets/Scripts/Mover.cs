using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;

    private void Start()
    {
        
    }

    private void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * _moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * _moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }
}
