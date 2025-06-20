using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;
    NavMeshAgent agent;

    void Start()
    {
        TryGetComponent(out agent);
    }

    void Update()
    {
        //GetComponent<NavMeshAgent>().destination = target.position;

        if (Input.GetMouseButtonDown(0))
        {
            MoveToCursor();
        }
        UpdateAnimator();
        //Debug.DrawRay(lastRay.origin, lastRay.direction * 100);
    }

    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray , out hit);

        if (hasHit)
        {
            target.position = hit.point;
            agent.SetDestination(target.position);
        }
    }

    private void UpdateAnimator()
    {
        Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;
        GetComponent<Animator>().SetFloat("forwardSpeed", speed);
    }
}
