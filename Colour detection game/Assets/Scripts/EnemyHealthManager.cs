using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour
{
    public PlayerController playerController;
    public Animator weaponAnimation;
    public AudioSource swipeSound;
    public AudioSource hitSound;
    public bool isEnemyHit;
    public PlayerHealthManager playerHealthManager;
    public GameObject player;

    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        playerHealthManager = FindObjectOfType<PlayerHealthManager>();
        player = GameObject.Find("PlayerHitBox");
    }

    void Update()
    {
        if(playerController)
        {
            weaponAnimation = playerController.GetComponent<Animator>();
            swipeSound = playerController.GetComponent<AudioSource>();
            if(player)
            {
                hitSound = player.GetComponent<AudioSource>();
            }
        }

        if (playerHealthManager.isRespawning)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Weapon")
        {
            Destroy(gameObject);
            swipeSound.Play();
            isEnemyHit = true;
            weaponAnimation.SetBool("isEnemyHit", isEnemyHit);
        }

        if (other.gameObject.tag == "Player")
        {
            hitSound.Play();
            playerHealthManager.TakeDamage();
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Weapon")
        {
            isEnemyHit = false;
            weaponAnimation.SetBool("isEnemyHit", isEnemyHit);
        }
    }

}