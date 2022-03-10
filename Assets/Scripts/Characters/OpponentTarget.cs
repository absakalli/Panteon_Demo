using UnityEngine;
using UnityEngine.AI;

public class OpponentTarget : MonoBehaviour
{
    private GameObject target;
    private NavMeshAgent agent;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target");
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.transform.position);
    }
}
