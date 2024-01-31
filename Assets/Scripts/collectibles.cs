using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibles : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Player touched the collectible, destroy it.
            Destroy(gameObject);
        }
    }

}
