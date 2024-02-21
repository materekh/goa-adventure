using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controler : MonoBehaviour
{
    [SerializeField] private Transform player;

    void Update()
    {
        if (transform != null)
        {
            float originalZ = transform.position.z;
            transform.position = new Vector3(player.position.x, player.position.y, originalZ);
        }
    }
}