using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeForce : MonoBehaviour
{
    public float thrust = 200.0f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.up * thrust);
    }
}
