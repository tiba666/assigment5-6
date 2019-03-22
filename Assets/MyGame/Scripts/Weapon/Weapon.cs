using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;
    public UIammo ui;
  



    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }   
    }

    void Shoot()
    {
        if (Ammo > 0)
        {
            Instantiate(bullet, firepoint.position, firepoint.rotation);
            Ammo -= 1;
            CallUI();
        }
    }
  public int Ammo = 0;
   
    public void AddAmmo(int getammo)
    {

        Ammo += getammo;
        CallUI();

    }


    private void CallUI()
    {
        ui.updateUI();
    }

}
