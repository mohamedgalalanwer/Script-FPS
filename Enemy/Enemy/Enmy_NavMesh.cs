using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enmy_NavMesh : MonoBehaviour {
    public Transform playerPostion;
    UnityEngine.AI.NavMeshAgent nma;
    // Use this for initialization
    void Awake()
    {
        playerPostion = GameObject.FindGameObjectWithTag("Player").transform;
        nma = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {


        nma.SetDestination(playerPostion.position);

    }
}
