using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour
{
    public int Health;



    private void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }


    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        // Destroy the whole Block
        Health -= 1;
    }
}