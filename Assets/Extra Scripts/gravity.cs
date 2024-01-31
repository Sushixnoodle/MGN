using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public Rigidbody rb;
    public float gravityScale = 45;
    private void FixedUpdate()
    {
        rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);
    }
}
