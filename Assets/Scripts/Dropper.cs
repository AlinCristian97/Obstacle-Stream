using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float _timeToWait = 5f;

    private MeshRenderer _renderer;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _renderer.enabled = false;
        _rigidbody.useGravity = false;
    }

    private void Update()
    {
        if(Time.time > _timeToWait)
        {
            _renderer.enabled = true;
            _rigidbody.useGravity = true;
        }
    }
}