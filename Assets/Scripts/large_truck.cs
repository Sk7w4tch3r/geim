using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class large_truck : MonoBehaviour
{
    public Rigidbody rb;
    public int speed;
    public Transform truckPosition;
    public Vector3 start_pos1;
    public Vector3 current1;
    // Start is called before the first frame update
    void Start()
    {
        start_pos1 = truckPosition.position;
        speed = 2;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, -speed);
    }
    void Update()
    {
        rb.velocity = new Vector3(0, 0, -speed);
        current1 = truckPosition.position;
        if (current1.z < -50.0)
        {
            Debug.Log("Out Of Bound");
            truckPosition.position = start_pos1;
        }
    }
}
