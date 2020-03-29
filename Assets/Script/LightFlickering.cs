using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickering : MonoBehaviour
{
    Light lightFlickering;

    void Start()
    {
        lightFlickering = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    IEnumerator Flashing ()
    {
        while (true)
        {
           yield return new WaitForSeconds(0.8f);
           lightFlickering.enabled = !lightFlickering.enabled;
                }  
    }
    

}
