using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class leftController : MonoBehaviour
{
    public Transform carPosition;
    public Rigidbody rb;
    private float speed = 2000f;
    public Vector3 leftPos = new Vector3(3f, 0.5f, -9f);
    public Vector3 rightPos = new Vector3(8f, 0.5f, -9f);
    public bool toggle = true;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("left"))
        {
            toggle = !toggle;
            if (toggle == true)
            {
                rb.velocity = new Vector3(speed * Time.deltaTime,0,0);
            }
            else
            {
                rb.velocity = new Vector3(-speed * Time.deltaTime, 0, 0);

            }

            //rb.MovePosition((Vector3)carPosition.position + (leftPos * speed * Time.deltaTime));
        }
    }
}
