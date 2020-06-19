using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;
public class swat_truck : MonoBehaviour
{
    public Rigidbody rb;
    public int speed;
    public Transform swatPosition;
    public Vector3 start_pos;
    public Vector3 current;
    // Start is called before the first frame update
    void Start()
    {
        start_pos = swatPosition.position;
        speed = 4;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, -speed);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, 0, -speed);
        current = swatPosition.position;
        if (current.z < -50.0)
        {
            Debug.Log("Out Of Bound");
            swatPosition.position = start_pos;
        }
    }
}
