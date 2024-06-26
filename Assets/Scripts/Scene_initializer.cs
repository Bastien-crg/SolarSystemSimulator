using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_initializer : MonoBehaviour
{
    public GameObject sun;
    public GameObject mercure;
    public GameObject venus;
    public GameObject earth;
    public GameObject mars;
    public GameObject jupiter;
    public GameObject saturn;
    public GameObject uranus;
    public GameObject neptune;
    public GameObject pluton;
    const float G = 66.74f;

    void initiateGravity(GameObject o1, GameObject o2, float speedMult)
    {
        Rigidbody rb = o1.GetComponent<Rigidbody>();
        float R = Vector3.Distance(o1.transform.position, o2.transform.position);
        float speed = Mathf.Sqrt((G * rb.mass) / R);
        Vector3 force = new Vector3(0, 0, 1);
        force *= speed * speedMult;
        Rigidbody rbSat = o2.GetComponent<Rigidbody>();
        rbSat.AddForce(force);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (pluton != null)
            initiateGravity(sun, pluton, 50);
        if (neptune != null)
            initiateGravity(sun, neptune, 50);
        if (uranus != null)
            initiateGravity(sun, uranus, 50);
        if (saturn != null)
            initiateGravity(sun, saturn, 50);
        if (jupiter != null)
            initiateGravity(sun, jupiter, 50);
        if (mars != null)
            initiateGravity(sun, mars, 50);
        if (earth != null)
            initiateGravity(sun, earth, 50);
        if (venus != null)
            initiateGravity(sun, venus, 50);
        if (mercure != null)
            initiateGravity(sun, mercure, 50);

    }
}
