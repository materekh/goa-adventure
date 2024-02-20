using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public List<GameObject> heartsList;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
        Die();
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        for (int heart = 5; heart != 0; heart--)
        {
            heartsList.RemoveAt(heartsList.Count - 1);
        }
    }

    void Die()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
