using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class bot : MonoBehaviour
{
     public Transform player;
    public float speed = 5f; 
    public float minDistance = 1.5f; 

    void Update()
    {
        if (player != null)
        {

            Vector3 direction = player.position - transform.position;
            

            float distance = direction.magnitude;

            if (distance > minDistance)
            {
                direction.Normalize(); 


                transform.Translate(direction * speed * Time.deltaTime);
            }
        }
    }
}

