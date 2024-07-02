using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "player") { 
            col.gameObject.GetComponent<Spaceship>().AddHealth();
            Destroy(gameObject);
        }
    }
}
