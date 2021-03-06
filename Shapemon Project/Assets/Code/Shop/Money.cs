﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Money : MonoBehaviour {

    public int Cash;
    public Text CashT;

    public int Bone;
    public Text BoneText;

    public static int HealthPoshin;
    public Text HealthPoshinText;

    public static int RedPokecubeNum;
    public Text RedPokecubeText;

    public static int BluePokecubeNum;
    public Text BluePokecubeText;

    public static int YellowPokecubeNum;
    public Text YellowPokecubeText;

    public static int MasterPokecubeNum;
    public Text MasterPokecubeText;

    // Use this for initialization
    void Start()
    {
        Cash = 0;
        Bone = 0;
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
    public void RedPokecube()
    {
        if (Cash >= 200)
        {
            Cash -= 200;
            RedPokecubeNum += 1;
        }
    }
    public void BluePokecube()
    {
        if (Cash >= 600)
        {
            Cash -= 600;
            BluePokecubeNum += 1;
        }
    }
    public void YellowPokecube()
    {
        if (Cash >= 1200)
        {
            Cash -= 1200;
            YellowPokecubeNum += 1;
        }
    }
    public void MasterPokecube()
    {
        if (Bone >= 10)
        {
            Bone -= 10;
            MasterPokecubeNum += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        HealthPoshinText.text = "" + HealthPoshin;
        RedPokecubeText.text = "" + RedPokecubeNum;
        BluePokecubeText.text = "" + BluePokecubeNum;
        YellowPokecubeText.text = "" + YellowPokecubeNum;
        MasterPokecubeText.text = "" + MasterPokecubeNum;
        CashT.text = "GeoCash  " + Cash;
        BoneText.text = "Bone  " + Bone;

        
    }
}
