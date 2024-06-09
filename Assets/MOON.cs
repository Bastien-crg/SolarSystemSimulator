using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOON : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 1f;
    public bool rotation = true;
    public float distance = 10f; // new property

    private void Update()
    {
        if (rotation)
        {
            Quaternion desiredRotation = Quaternion.Euler(0f, Time.time * rotationSpeed, 0f);

            transform.position = target.position + desiredRotation * Vector3.back * distance;
            transform.LookAt(target.position);
        }
    }

    public void setRotation(bool newRotation)
    {
        rotation = newRotation;
    }
}
