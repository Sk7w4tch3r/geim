using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class rightController : MonoBehaviour
{
    public Transform carPosition;
    public Rigidbody rb;
    public Vector3 leftPos = new Vector3(1f, 0.5f, -9f);
    public Vector3 rightPos = new Vector3(3f, 0.5f, -9f);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("j"))
        {
            carPosition.position = leftPos;
        }
        else if (Input.GetKey("l"))
        {
            carPosition.position = rightPos;
        }
    }
}
