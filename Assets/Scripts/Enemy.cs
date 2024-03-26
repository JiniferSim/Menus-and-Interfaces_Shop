using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform player;
    public float speed = 4f;
    public float attackSpeed = 6f;
    bool touchPlayer;
    private bool canAttack = true;
    private float lastAttackTime;
    Rigidbody rb;
    Animator animator;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (touchPlayer)
        {
            if (touchPlayer && canAttack)
            {
                lastAttackTime = Time.time;
                canAttack = false;
            }
        }
        else if (!touchPlayer && !canAttack)
        {
            canAttack = true;
        }
        else
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            rb.MovePosition(pos);
        }
        transform.LookAt(player);
        animator.SetTrigger("Attack");
    }
    private void Update()
    {
        if (!canAttack && Time.time - lastAttackTime > attackSpeed)
        {
            canAttack = true;
            animator.SetTrigger("Attack");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            touchPlayer = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            touchPlayer = false;
        }
    }
}
