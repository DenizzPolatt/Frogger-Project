using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float forwardInput;
    private float tWait = 5.0f;
    private float tActive;
    
    public float speed;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI winningText;
    public Button restartButton;

    [SerializeField] private GameObject[] models;

    private void Start()
    {
        int index = PlayerPrefs.GetInt("PlayerIndex");
        models[index].SetActive(true);
    }

    // Update is called once per frame
    private void Update()
    {
        tActive += Time.deltaTime;
        if (tActive < tWait)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            return;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * (speed * Time.deltaTime * forwardInput));
        transform.Translate(Vector3.right * (speed * Time.deltaTime * horizontalInput));
        
        if (transform.position.x < -16)
        {
            transform.position = new Vector3(-16, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > 16)
        {
            transform.position = new Vector3(16, transform.position.y, transform.position.z);
        }

        if (transform.position.z > 2.5)
        {
            transform.position = new  Vector3(transform.position.x, transform.position.y, 2.5f);
            
        }
        
        if (transform.position.z < -18)
        {
            transform.position = new  Vector3(transform.position.x, transform.position.y, -18);
            
        }
        
        WinTheGame();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Vehicle"))
        {
            speed = 0;
            transform.localScale = new Vector3(2, 0.05f, 1);
            gameOverText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        }
    }

    private void WinTheGame()
    {
        if (transform.position.z > 1)
        {
            speed = 0;
            winningText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        }
    }
}
