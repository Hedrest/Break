using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roofblock : MonoBehaviour {

    public GameObject rooftop;

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Player")
        {
            Destroy(rooftop);
        }
        
    }
}
