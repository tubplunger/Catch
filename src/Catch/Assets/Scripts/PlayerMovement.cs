using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 100f;

    private Rigidbody rb;
    private float moveInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // horizontal input
        moveInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        // move on X axis
        rb.velocity = new Vector3(moveInput * moveSpeed, 0f, 0f);
    }
}
