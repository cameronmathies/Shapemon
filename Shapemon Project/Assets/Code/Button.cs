using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
    public bool interactable { get; internal set; }

    public void Play()
    {
        Application.LoadLevel("Level1");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
