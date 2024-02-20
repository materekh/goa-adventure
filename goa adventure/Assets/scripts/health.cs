using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    [SerializeField] public List<GameObject> heartsList;

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
        if(heartsList.Count>0){
            Destroy(heartsList[heartsList.Count - 1]);
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
