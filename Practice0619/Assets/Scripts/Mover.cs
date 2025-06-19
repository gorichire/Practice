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
        agent.SetDestination(target.position);
    }
}
