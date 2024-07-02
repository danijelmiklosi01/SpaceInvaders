using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    int dir = 1;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void ChangeDirection ()
    {
        dir *= -1;
    }

    public void ChangeColor(Color col)
    {
        GetComponent<SpriteRenderer>().color = col;
    }

    void Update()
    {
        rb.velocity = new Vector2(0,6 * dir);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (dir == 1) { 
            if (col.gameObject.tag == "enemy") { 
                col.gameObject.GetComponent<Enemy>().Damage();
                Destroy(gameObject);
            }
        }
        else { 
            if (col.gameObject.tag == "player")
            {
                col.gameObject.GetComponent<Spaceship>().Damage();
                Destroy(gameObject);
            }
        }
    }
}
