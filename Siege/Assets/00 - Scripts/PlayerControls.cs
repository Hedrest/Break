using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControls : MonoBehaviour
{

    public NavMeshAgent agent;
    public Animator anim;

    public float speed = 2f;
    public LayerMask layerMask;
    public float rotationSpeed;

    private Camera mainCamera;

    public void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
    }

    public void Move()
    {

        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        agent.velocity = Movement * speed;

    }


    void Update()
    {

        float moveSpeed = agent.velocity.magnitude / agent.speed;
        anim.SetFloat("MoveSpeed", moveSpeed);

        Move();

        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLenght;


        if (groundPlane.Raycast(cameraRay, out rayLenght))
        {
            Vector3 lookDirection = cameraRay.GetPoint(rayLenght);

            transform.LookAt(new Vector3(lookDirection.x, lookDirection.y, lookDirection.z));
        }

      

    }
}
