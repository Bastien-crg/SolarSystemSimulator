using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    const float G = 66.74f;
    public Rigidbody rb;

    public static List<Attractor> Attractors;

    private void OnEnable()
    {
        if (Attractors == null)
        {
            Attractors = new List<Attractor>();
        }
        Attractors.Add(this);
    }

    private void OnDisable()
    {
        Attractors.Remove(this);
    }
    void Attract (Attractor other)
    {
        Rigidbody rbToAttract = other.rb;

        Vector3 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;
        float forceMagnitude = G * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector3 force = direction.normalized * forceMagnitude;
        rbToAttract.AddForce(force);

    }

    private void FixedUpdate()
    {
        foreach (Attractor attractor in Attractors)
        {
            if (attractor != this)
            {
                Attract(attractor);
            }
        }
    }
}
