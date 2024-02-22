using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    public float floatHeight = 4f;   // The maximum height the object will float above its initial position.
    public float floatSpeed = 50f;    // The speed of the floating motion.

    private Vector3 initialPosition;
    private Vector3 targetPosition;

    private void Start()
    {
        initialPosition = transform.position;
        targetPosition = initialPosition + Vector3.up * floatHeight;
    }

    private void Update()
    {
        // Calculate the new position using Lerp to create a smooth floating effect.
        float t = (Mathf.Sin(Time.time * floatSpeed) + 1) / 2; // Normalize the sine wave to [0, 1].
        Vector3 newPosition = Vector3.Lerp(initialPosition, targetPosition, t);

        // Update the GameObject's position.
        transform.position = newPosition;
    }
}
