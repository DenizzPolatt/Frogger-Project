using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    private float speed = 10;
    private float xRange = 40;
    
    // Start is called before the first frame update
    public void Init(float speed)
    {
        this.speed = speed;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.down * (speed * Time.deltaTime));
        DestroyIfOutOfBounds();
    }

    private void DestroyIfOutOfBounds()
    {
        if (transform.position.x > xRange && transform.position.x < -xRange)
        {
            Destroy(gameObject);
        }
    }
    
}
