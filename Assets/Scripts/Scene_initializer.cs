using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_initializer : MonoBehaviour
{
    public GameObject sun;
    public GameObject mercure;
    public GameObject venus;
    public GameObject earth;
    public GameObject moon;
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
        Debug.Log(speed);
        Vector3 force = new Vector3(0, 0, 1);
        force *= speed * speedMult;
        Rigidbody rbSat = o2.GetComponent<Rigidbody>();
        rbSat.AddForce(force);
    }

    // Start is called before the first frame update
    void Start()
    {
        initiateGravity(sun, pluton, 50);
        initiateGravity(sun, neptune, 50);
        initiateGravity(sun, uranus, 50);
        initiateGravity(sun, saturn, 50);
        initiateGravity(sun, jupiter, 50);
        initiateGravity(sun, mars, 50);
        initiateGravity(sun, earth, 50);
        initiateGravity(earth, moon, 3.5f);
        initiateGravity(sun, venus, 50);
        initiateGravity(sun, mercure, 50);
    }
}
