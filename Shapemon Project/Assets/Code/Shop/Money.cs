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
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Test");
        if (other.tag == "Item Level1")
        {
            Cash += 10;
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
