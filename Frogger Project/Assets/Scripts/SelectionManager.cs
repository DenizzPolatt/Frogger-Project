using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using Color = System.Drawing.Color;

public class SelectionManager : MonoBehaviour
{
    
    private void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform != null)
            {
                var index = hit.transform.gameObject.GetComponent<SelectableCharacter>().Index;
                hit.transform.gameObject.GetComponent<SelectableCharacter>().selected = true;
                hit.transform.GetComponentInChildren<Renderer>().material.color = UnityEngine.Color.green;
                
                if (Input.GetMouseButtonDown(0))
                {
                    PlayerPrefs.SetInt("PlayerIndex", index);
                }
            }
        }
        
        
    }
}
