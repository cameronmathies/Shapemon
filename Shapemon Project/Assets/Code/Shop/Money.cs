﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Money : MonoBehaviour {

    public static int Cash;
    public Text CashT;
    public static int HealthPoshin;
    public Text HealthPoshinText;

    // Use this for initialization
    void Start()
    {
        Cash = 0;
    }
    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Item_Level1")
        {
            Debug.Log("1");
            Cash += 10;
       }
        if (other.gameObject.tag == "Item_Level2")
        {
            Debug.Log("2");
            Cash += 20;
        }
    }
    public void HealthPshin()
    {
       if(Cash >= 500)
        {
            Cash -= 500;
            HealthPoshin += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        HealthPoshinText.text = "" + HealthPoshin; 
        CashT.text = "GeoCash  " + Cash;

        if (Cash > 1000000)
        {
            Cash -= 1000000;
        }
    }
}
