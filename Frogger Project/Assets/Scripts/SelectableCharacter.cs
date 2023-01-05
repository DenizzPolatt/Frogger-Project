using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableCharacter : MonoBehaviour
{
    [SerializeField] private int index;
    public int Index => index;
    public bool selected;

    private void LateUpdate()
    {
        if (!selected)
        {
            if (PlayerPrefs.GetInt("PlayerIndex", -1) == index)
            {
                GetComponentInChildren<Renderer>().material.color = UnityEngine.Color.magenta;
            }
            else
            {
                GetComponentInChildren<Renderer>().material.color = UnityEngine.Color.white;
            }
        }

        selected = false;
    }
}
