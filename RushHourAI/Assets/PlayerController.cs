using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public GameObject[] Targets;
    public GameObject SelectedTarget;
    public NavMeshAgent Agent;

    // Start is called before the first frame update
    void Start()
    {
        SelectTarget();
        Agent.SetDestination(SelectedTarget.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelectTarget(){
        SelectedTarget = Targets[Random.Range(0, 4)];
    }

}
