using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public static class EnemyStaticClass
{
    public static void Run(Transform transform, Vector3 target, float visionCone, NavMeshAgent enemyNavMesh)
    {
        if (Physics.OverlapSphere(transform.position, visionCone, LayerMask.GetMask("Player")).Length > 0)
        {
            enemyNavMesh.SetDestination(target);
        }
    }
}
