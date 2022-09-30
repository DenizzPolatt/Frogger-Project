using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuUIHandler : MonoBehaviour
{ 
    public void NewPlayerSelected(int index)
    {
        PlayerPrefs.SetInt("PlayerIndex", index);
    }
}
