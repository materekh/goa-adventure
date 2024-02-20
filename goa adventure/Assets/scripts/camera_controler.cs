using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controler : MonoBehaviour
{
    [SerializeField] private Transform player;

    void Update()
    {
        // Keep the original Z position of the camera
        float originalZ = transform.position.z;

        // Set the new position based on the player's X and Y position
        transform.position = new Vector3(player.position.x, player.position.y, originalZ);
    }
}
