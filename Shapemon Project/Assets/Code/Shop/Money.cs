using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Money : MonoBehaviour {

    public int Cash;
    public Text CashT;
  
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
    // Update is called once per frame
    void Update()
    {

        CashT.text = "GeoCash  " + Cash;

        if (Cash > 1000000)
        {
            Cash -= 1000000;
        }
    }
}
