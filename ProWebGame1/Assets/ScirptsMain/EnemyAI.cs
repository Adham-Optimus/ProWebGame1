using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent _agent;
    private Transform _player;
    public bool playerInView;
    public float radius;
    private LayerMask playerL, groundL;
    private Vector3 walkPoint;
    public float walkRange;
    public bool walkPointSet;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _agent = GetComponent<NavMeshAgent>();
        playerL = LayerMask.GetMask("Player");
        groundL = LayerMask.GetMask("Ground");
    }

    private void Update()
    {
        playerInView = Physics.CheckSphere(transform.position, radius, playerL);

        if (playerInView)
        {
            Attacking();
        }
        else if (playerInView == false)
        {
            Patrolling();
        }
    }

    private void Patrolling()
    {
        if (walkPointSet) _agent.SetDestination(walkPoint);
        if (!walkPointSet) SearchWalkPoint();

        Vector3 distanceToPoint = transform.position - walkPoint;

        if(distanceToPoint.magnitude< 2)
        {
            walkPointSet = false;
        }
    }

    private void SearchWalkPoint()
    {
        float x = Random.Range(-walkRange, walkRange);
        float z = Random.Range(-walkRange, walkRange);

        walkPoint = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);

        if(Physics.Raycast(walkPoint, -transform.up, groundL))
        {
            walkPointSet = true;
        }
    }

    private void Attacking()
    {
        _agent.SetDestination(_player.position);
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(walkPoint, 2);
    }
}
