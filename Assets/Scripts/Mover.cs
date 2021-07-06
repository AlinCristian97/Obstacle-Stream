using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;

    private void Start()
    {
        PrintInstructions();
    }

    private void Update()
    {
        MovePlayer();
    }
    
    private void PrintInstructions() 
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    private void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * _moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * _moveSpeed;
        
        transform.Translate(xValue, 0, zValue);
    }
    

}
