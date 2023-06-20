using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{


    public bool hasEnded;

    public Text CounterText;

    private int Count = 0;   

    private void Start()
    {
        Count = 0;  
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += 1;                
        CounterText.text = "Count : " + Count;
        other.gameObject.tag = "ended";
    }
}
