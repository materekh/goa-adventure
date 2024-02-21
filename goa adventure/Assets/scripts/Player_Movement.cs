using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        if(movementDirection != null)
        {
            movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));


            if (movementDirection.magnitude > 0.1f && !audioSource.isPlaying)
            {
                audioSource.Play();
            }

            else if (movementDirection.magnitude < 0.1f && audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }

    void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }
}
