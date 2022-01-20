using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WheelyChair : MonoBehaviour
{
    private NavMeshAgent _enemyNavMesh;
    
    public Transform playerPos;
    public float visionCone;
    // Start is called before the first frame update
    void Start()
    {
        _enemyNavMesh = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 runAway = transform.position - playerPos.position;
        EnemyStaticClass.Run(transform, runAway, visionCone, _enemyNavMesh);
    }
}
