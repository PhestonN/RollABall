using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class playerControl : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;
    private float xInput;
    private float yInput;
    
    
   
    
    private void Start()
    {
        
        
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }

   
    void Update()
    {
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
        

    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, yInput) * moveSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickUp"))
        {
            
            other.gameObject.SetActive(false);
            
        }
    }

   

    
    }

