using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public void Play()
    {
        Application.LoadLevel("Level1");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
