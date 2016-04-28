using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {

	public Text playerHealthText;
	int totalHealth = 100;

	void Start () {
		playerHealthText.text = totalHealth + "%";
	}
	
	// Update is called once per frame
	void Update () {
		if (totalHealth <= 0)
		{
			Application.LoadLevel("floor7");
		}
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Item_Level1")
		{
			totalHealth -= 15;
			playerHealthText.text = totalHealth + "%";
		}
	}
}
