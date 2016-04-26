﻿using UnityEngine;
using System.Collections;

public class ScaleTest : MonoBehaviour {

    // This is the time it takes to scale up/down.
    public float duration = 1.5f;

    // This remains true while it is in the prossess of scaling.
    private bool isScaling = false;


    // This is called every frame.  I will use it to check if space is pressed down, then trigger the scale.
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(DoScaleThing());
        }
    }

    public IEnumerator DoScaleThing()
    {

        // Check if we are scaling now, if so exit method to avoid overlap.
        if (isScaling)
            yield break;

        // Declare that we are scaling now.
        isScaling = true;

        // Grab the current time and store it in a variable.
        float startTime = Time.time;

        while (Time.time - startTime < duration)
        {
            float amount = (Time.time - startTime) / duration;
            transform.localScale = Vector3.Lerp(Vector3.one, Vector3.one * 1.5f, amount);
            yield return null;
        }

        // Snap the scale to 3.0f.
        transform.localScale = Vector3.one * 1.5f;

        // Leave the scale at 3 for 2 seconds (this can be changed at any time).
        yield return new WaitForSeconds(0.25f);

        // Now for the scale down part.  Store the current time in the same variable.
        startTime = Time.time;

        while (Time.time - startTime < duration)
        {
            float amount = (Time.time - startTime) / duration;
            transform.localScale = Vector3.Lerp(Vector3.one * 1.5f, Vector3.one, amount);
            yield return null;
        }

        // Snap the scale to 1.0.
        transform.localScale = Vector3.one;

        // Declare that we are no longer modifing the scale.
        isScaling = false;
    }
}
