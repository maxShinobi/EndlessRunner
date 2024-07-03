using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float horizontalMultiplier = 2f;
    public Rigidbody rb;

    float horizontalInput;

    private void FixedUpdate()
    {
        Vector3 forwardMovement = transform.forward * playerSpeed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * playerSpeed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMovement + horizontalMove);
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
