using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_initializer : MonoBehaviour
{
    public GameObject sun;
    public GameObject sat;
    const float G = 66.74f;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = sun.GetComponent<Rigidbody>();
        float R = Vector3.Distance(sun.transform.position, sat.transform.position);
        float speed = Mathf.Sqrt((G * rb.mass) / R);
        Debug.Log(speed);
        Vector3 force = new Vector3(0, 0, 1);
        force *= speed*50;
        Rigidbody rbSat = sat.GetComponent<Rigidbody>();
        rbSat.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
