using UnityEngine;
using UnityEngine.AI;

public class OpponentTarget : MonoBehaviour
{
    private GameObject target;
    private NavMeshAgent agent;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target");
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.transform.position);
    }
}
