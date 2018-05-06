using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (LineRenderer))]

public class LaserCast : MonoBehaviour {

    private LineRenderer laserSight;

	// Use this for initialization
	void Start () {
        laserSight = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                laserSight.SetPosition(1, new Vector3(0, 0, hit.distance));
            }

        }
        else
        {
            laserSight.SetPosition(1, new Vector3(0, 0, 100));
        }

    
	}
}
