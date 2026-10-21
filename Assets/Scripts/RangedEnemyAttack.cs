using UnityEngine;
using UnityEngine.AI;

public class RangedEnemyAttack : MonoBehaviour
{

    public GameObject target;
    public float attackRange = 1;
    public float attackDelay = 1;

    private NavMeshAgent rEnemy;
    private float attackCooldown;


    private void Awake()
    {
        rEnemy = GetComponent<NavMeshAgent>();
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
                rEnemy.isStopped = false;
            }
            else
            {
                rEnemy.isStopped = true;
                Attack();
            }
        }
    }
    private void Attack()
    {
        if (attackCooldown <= 0)
        {
                transform.LookAt(target.transform.position);
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.forward, out hit, attackRange))
                {
                    Health hitHealth = hit.transform.GetComponent<Health>();
                    if (hitHealth != null)
                    {
                        hitHealth.Damage(10);
                    }

                }
                attackCooldown = attackDelay;
            }
    }
}
