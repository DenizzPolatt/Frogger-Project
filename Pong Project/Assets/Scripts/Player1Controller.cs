using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    private float speed = 60;
    private float zRange = 26.5f;

    private void Update()
    {
        if(Input.GetKey(KeyCode.W)) 
            transform.Translate(Vector3.forward * Time.deltaTime * speed );
        if(Input.GetKey(KeyCode.S)) 
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed );

        if (transform.position.z >= zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        
        if (transform.position.z <= -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
    }
}
