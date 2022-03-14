using UnityEngine;
using UnityEngine.AI;

public class Opponent : Characters
{
    [SerializeField] private GameObject target;
    private NavMeshAgent agent;

    private void Start()
    {
        SetTarget();
    }

    private void SetTarget()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.transform.position);
    }
}
