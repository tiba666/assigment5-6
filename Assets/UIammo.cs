using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIammo : MonoBehaviour
{

    public Text Ammo;
    public GameObject player;

    private void Start()
    {
        Invoke("Text", .01f);
    }

    void Text()
    {
        Weapon weapon = player.GetComponent<Weapon>();
        Ammo.text = "ammo "+weapon.Ammo; 
    }

    public void updateUI()
    {
        Text();
    }

}
