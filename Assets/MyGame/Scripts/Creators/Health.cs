using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int HP = 100;
   
    public void TakeDmg(int dmg)
    {
        HP -= dmg;
        if(HP <= 0)
        {
            Destroy(gameObject);
        }
    }

}
