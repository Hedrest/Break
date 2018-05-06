using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToplayer : MonoBehaviour {

    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;


    public void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedSpeed = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedSpeed;
    }
}
