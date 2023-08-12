using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingCandle : MonoBehaviour
{
    public float floatHeight = 1.0f;       // Height at which the object floats
    public float bobSpeed = 1.0f;          // Speed of bobbing
    public float bobHeight = 0.1f;         // Amplitude of bobbing

    private Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the new y-position based on a sine wave to achieve bobbing effect
        float newY = originalPosition.y + Mathf.Sin(Time.time * bobSpeed) * bobHeight;

        // Set the new position of the object
        transform.position = new Vector3(originalPosition.x, newY + floatHeight, originalPosition.z);
    }
}
