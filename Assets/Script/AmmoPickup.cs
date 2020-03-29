using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public GameObject Ammo;

    void OnTriggerEnter(Collider other)
    {
        Destroy(Ammo);

        if (other.gameObject.CompareTag("Ammo"))
        {
            other.gameObject.SetActive(true);
            Debug.Log("Ammo collected!!");
        }
      
    }
}




            