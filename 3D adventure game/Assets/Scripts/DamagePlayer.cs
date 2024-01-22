using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public EnemyController enemy;
    public PlayerController player;
    public HealthManager healthManager;

    public AudioSource growl;
    public Animator m_Animator;

    public bool isAttackingPlayer = false;
    public int damageToGive = 1;

    // Start is called before the first frame update
    void Start()
    {
        enemy = gameObject.GetComponentInParent<EnemyController>();
        player = FindObjectOfType<PlayerController>();
        healthManager = FindObjectOfType<HealthManager>();

        growl = gameObject.GetComponentInParent<AudioSource>();
        m_Animator = gameObject.GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        m_Animator.SetBool("isAttacking", isAttackingPlayer);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            growl.Play();
            isAttackingPlayer = true;
            Vector3 hitDirection = other.transform.position - transform.position;
            hitDirection = hitDirection.normalized;

            player.KnockBack(hitDirection);

            healthManager.currentHealth--;
            healthManager.HurtPlayer(damageToGive);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isAttackingPlayer = false;
        }
    }
}
