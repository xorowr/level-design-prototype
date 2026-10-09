using UnityEngine;
using UnityEngine.AI;

public class AIChase : MonoBehaviour
{

    public GameObject target;
    public float attackRange = 1;
    public float attackDelay = 1;

    private NavMeshAgent enemy;
    private float attackCooldown;


    private void Awake()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (attackCooldown > 0) 
        {
            attackCooldown -= Time.deltaTime;
        }

        if (target != null)
        {
            if (Vector3.Distance(transform.position, target.transform.position) > attackRange)
            {
                enemy.isStopped = false;
                enemy.destination = target.transform.position;
            }
            else
            {
                enemy.isStopped = true;
                Attack();
            }
        }
    }
    private void Attack()
    {
        if (attackCooldown <= 0)
        {
            Health targetHealth = target.GetComponent<Health>();
            if (targetHealth != null)
            {
                targetHealth.Damage(10);
            }
            attackCooldown = attackDelay;
        }
    }
}
