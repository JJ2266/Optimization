using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    NavMeshAgent agent;
    EnemyHealth enemyhealth;
    PlayerHealth playerhealth;
    private void Start()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        playerhealth = player.GetComponent<PlayerHealth>();
        enemyhealth = GetComponent<EnemyHealth>();
    }
    void Update ()
    {
        

        if (enemyhealth.currentHealth > 0 && playerhealth.currentHealth > 0)
        {
            agent.SetDestination (player.position);
        }
        else
        {
            agent.enabled = false;
        }
    }
}
