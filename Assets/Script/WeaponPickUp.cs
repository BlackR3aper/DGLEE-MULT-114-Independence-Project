using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{ 
    public GameObject realM4;
    public GameObject fakeM4;
    void OnTriggerEnter(Collider other)
    {
        realM4.SetActive(true);
        fakeM4.SetActive(false);
        Debug.Log("You picked up a weapon");
        Debug.Log("Defeat enemies and head to any room");
    }
}
