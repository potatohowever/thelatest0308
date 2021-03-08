using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;


public class stage_3_chasingenemy : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
    }
}
