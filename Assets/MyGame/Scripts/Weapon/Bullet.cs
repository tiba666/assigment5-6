using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Health Obj = collision.GetComponent<Health>();
        
        if(Obj != null)
        {
            Obj.TakeDmg(10);
        }

        Debug.Log(collision.name); 
        Destroy(gameObject);

    }
}

   
