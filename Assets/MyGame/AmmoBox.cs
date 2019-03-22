using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    private bool canpickup = true;
    public int Ammoamount;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (canpickup)
        {

            if (collision.gameObject.CompareTag("Player"))
            {
                canpickup = false;
                Destroy(gameObject);
                Weapon weapon = collision.GetComponent<Weapon>();
                // weapon.enabled = true;
                weapon.AddAmmo(Ammoamount);

            }
        }

    }
}
