using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    
    public GameObject[] vehicles;

    [SerializeField] private float speed = 10;
    private float timer = 0;
    [SerializeField] private float spawnTime = 1;
    

    // Update is called once per frame
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnTime)
        {
            int vehicleIndex = Random.Range(0, 5);
            var go = Instantiate(vehicles[vehicleIndex], transform.position, transform.rotation);
            go.GetComponent<Vehicle>().Init(speed);
            timer = 0;
        }
    }
    
    
    
}
