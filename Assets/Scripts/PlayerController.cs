﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float horizontalInput;
    public float verticalSpeed = 7f;
    public float horizontalSpeed = 8f;
    public GameObject sparklesPrefab;
    public float timer;
    public float timeLimit = 0.5f;
    private float rightRange = -3;
    private float leftRange = -9;
    private float topRange = 5.5f;
    private float bottomRange = -2.8f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftRange)
        {
            transform.position = new Vector3(leftRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > rightRange)
        {
            transform.position = new Vector3(rightRange, transform.position.y, transform.position.z);
        }

        if (transform.position.y < bottomRange)
        {
            transform.position = new Vector3(transform.position.x, bottomRange, transform.position.z);
        }

        if (transform.position.y > topRange)
        {
            transform.position = new Vector3(transform.position.x, topRange, transform.position.z);
        }

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed * horizontalInput);

        transform.Translate(Vector3.up * Time.deltaTime * verticalSpeed * verticalInput);

        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space)&& timer > timeLimit)
        {
            Instantiate(sparklesPrefab, transform.position, sparklesPrefab.transform.rotation);

            timer = 0;
        }


    }
}