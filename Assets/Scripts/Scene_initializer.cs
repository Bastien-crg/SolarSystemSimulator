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
    public GameObject uranus;
    public GameObject neptune;
    public GameObject pluton;
    const float G = 66.74f;

    void initiateGravity(GameObject o1, GameObject o2)
    {
        Rigidbody rb = o1.GetComponent<Rigidbody>();
        float R = Vector3.Distance(o1.transform.position, o2.transform.position);
        float speed = Mathf.Sqrt((G * rb.mass) / R);
        Debug.Log(speed);
        Vector3 force = new Vector3(0, 0, 1);
        force *= speed * 50;
        Rigidbody rbSat = o2.GetComponent<Rigidbody>();
        rbSat.AddForce(force);
    }

    // Start is called before the first frame update
    void Start()
    {
        initiateGravity(sun, pluton);
        initiateGravity(sun, neptune);
        initiateGravity(sun, uranus);
        initiateGravity(sun, jupiter);
        initiateGravity(sun, mars);
        initiateGravity(sun, earth);
        initiateGravity(sun, venus);
        initiateGravity(sun, mercure);
    }
}
