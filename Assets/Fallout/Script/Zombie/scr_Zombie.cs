using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class scr_Zombie : MonoBehaviour
{
    [Header("References")]
    public AudioClip diedAudioClip;
    private Transform player;
    public float attackDistance = 1.5f;
    public float attackRate = 1.0f;
    public int attackDamage = 10;

    private NavMeshAgent agent;
    private Animator animator;
    private AudioSource audioSource;
    private scr_ZombieHealth zombieHealth;
    private float nextAttackTime;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        zombieHealth = GetComponent<scr_ZombieHealth>();
        audioSource = GetComponent<AudioSource>();
        player = FindObjectOfType<scr_CharacterController>().transform;
    }

    void Update()
    {
        if (zombieHealth.IsDead())
        {
            agent.enabled = false;
            animator.SetBool("attack",false);
            animator.SetBool("isDied",true);
            audioSource.mute = true;
            Destroy(this);
            return;
        }

        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if (distanceToPlayer - 1.5 <= attackDistance)
        {
            AttackPlayer();
        }
        else
        {
            ChasePlayer();
        }
    }

    void ChasePlayer()
    {
        animator.SetBool("attack",false);
        agent.SetDestination(player.position);
    }

    void AttackPlayer()
    {
        agent.SetDestination(transform.position);
        animator.SetBool("attack",true);
        if (Time.time >= nextAttackTime)
        {
            player.GetComponent<scr_PlayerHealth>().TakeDamage(attackDamage);
            nextAttackTime = Time.time + attackRate;
        }
    }
}
