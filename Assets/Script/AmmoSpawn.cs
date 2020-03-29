using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSpawn : MonoBehaviour
{
    public GameObject Ammo;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAmmo", 1, 1);
    }

    // Update is called once per frame
    void SpawnAmmo()
    {
        Instantiate(Ammo, new Vector3(-2.5f, 2.65f, -22f), Quaternion.identity);
    }
}

