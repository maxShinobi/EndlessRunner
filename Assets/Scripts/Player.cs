using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float horizontalMultiplier = 2f;
    public float playerHealth = 10f;
    public Rigidbody rb;

    float horizontalInput;

    bool alive = true;

    private void Start()
    {
        playerHealth = 10f;
    }

    private void FixedUpdate()
    {
        if (!alive)
        {
            return;
        }

        Vector3 forwardMovement = transform.forward * playerSpeed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * playerSpeed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMovement + horizontalMove);
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    public void Die()
    {
        if (playerHealth <= 0)
        {
            Debug.Log("Player died");
            alive = false;
            //restart the game
            Invoke("Restart", 2);
        }
    }

    private void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
