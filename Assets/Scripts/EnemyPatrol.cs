using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SocialPlatforms.GameCenter;

public class EnemyPatrol : MonoBehaviour
{
    public NavMeshAgent rEnemy;
    public float range;
    public Transform CentrePoint;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rEnemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rEnemy.remainingDistance <= rEnemy.stoppingDistance)
        {
            Vector3 point;
            if (RandomPoint(CentrePoint.position, range, out point))
            {
                rEnemy.SetDestination(point);
            }
        }


    }

    bool RandomPoint(Vector3 centre, float range, out Vector3 result)
    {
        Vector3 randomPoint = centre + Random.insideUnitSphere * range;
        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomPoint, out hit, 5.0f, NavMesh.AllAreas))
        {
            result = hit.position;
            return true;
        }
        result = Vector3.zero;
        return false;
    }

}
