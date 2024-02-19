using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2f;
    private Rigidbody2D rb;
    [SerializeField] private AudioSource audioSource;
    private Vector2 movementDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        // Check if the player is moving and play audio
        if (movementDirection.magnitude > 0.1f && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
        // If the player is not moving, stop the audio
        else if (movementDirection.magnitude < 0.1f && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }

    void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }
}
