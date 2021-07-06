using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int _hits;
    
    private void OnCollisionEnter(Collision other) 
    {
        _hits++;
        Debug.Log("You've bumped into a thing this many times: " + _hits);
    }
}
