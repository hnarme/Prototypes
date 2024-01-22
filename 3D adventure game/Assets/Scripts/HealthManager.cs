using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public PlayerController thePlayer;
    public Renderer playerRenderer;
    public Animator deathAnimator;
    public Image blackScreen;
    public HealthBar healthBar;
    public AudioSource ouch;
    public AudioSource dying;

    public int currentHealth;
    public int maxHealth;
    public bool isDead = false;

    public float InvincibilityLength;
    private float InvincibilityCounter;

    private float flashCounter;
    private float flashLength = 0.1f;

    private bool isRespawning;
    private Vector3 respawnPoint;
    public float respawnLength;

    public bool playerHit = false;

    private bool isFadeToBlack;
    private bool isFadeFromBlack;
    public float fadeSpeed;
    public float waitForFade;
    
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        playerRenderer = GameObject.Find("Player 1").GetComponentInChildren<Renderer>();
        deathAnimator = GameObject.Find("Player 1").GetComponent<Animator>();
        healthBar.SetMaxHealth(maxHealth);
        ouch = GameObject.Find("Player 1").GetComponentInChildren<AudioSource>();
        dying = GameObject.Find("Dying").GetComponent<AudioSource>();
        
        currentHealth = maxHealth;

        respawnPoint = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (InvincibilityCounter > 0)
        {
            InvincibilityCounter -= Time.deltaTime;

            flashCounter -= Time.deltaTime;

            if(flashCounter <= 0)
            {
                playerRenderer.enabled = !playerRenderer.enabled;
                flashCounter = flashLength;
            }

            if(InvincibilityCounter <= 0)
            {
                playerRenderer.enabled = true;
            }
        }

        if(isFadeToBlack)
        {
            blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 1f, fadeSpeed * Time.deltaTime));
            if(blackScreen.color.a == 1f)
            { 
                isFadeToBlack = false;
            }
        }

        if (isFadeFromBlack)
        {
            blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 0f, fadeSpeed * Time.deltaTime));
            if (blackScreen.color.a == 0f)
            {
                isFadeFromBlack = false;
            }
        }

        deathAnimator.SetBool("isDead", isDead);
    }

    public void HurtPlayer(int damage)
    {
        ouch.Play();
        playerHit = true;

        if (InvincibilityCounter <= 0)
        {
            currentHealth -= damage;

            if (currentHealth <= 0)
            {
                Respawn();
            }
            else
            {
                InvincibilityCounter = InvincibilityLength;

                playerRenderer.enabled = false;

                flashCounter = flashLength;
            }
        }

        healthBar.SetHealth(currentHealth);
    }

    public void InstantKill()
    {
        if (InvincibilityCounter <= 0)
        {
            if (currentHealth >= 0)
            {
                if (!isRespawning)
                {
                    StartCoroutine("RespawnCo");
                }
            }
        }

        healthBar.SetHealth(currentHealth);
    }

    public void Respawn()
    {
        if (!isRespawning)
        {
            StartCoroutine("RespawnCo");
        }
    }

    public IEnumerator RespawnCo()
    {
        dying.Play();

        isRespawning = true;
        isDead = true;
        deathAnimator.SetBool("isDead", isDead);

        thePlayer.gameObject.SetActive(false);

        currentHealth = maxHealth;

        yield return new WaitForSeconds(respawnLength);

        isFadeToBlack = true;

        yield return new WaitForSeconds(waitForFade);

        isFadeToBlack = false;
        isFadeFromBlack = true;

        isRespawning = false;
        isDead = false;

        thePlayer.transform.position = respawnPoint;
        thePlayer.gameObject.SetActive(true);

        InvincibilityCounter = InvincibilityLength;
        playerRenderer.enabled = false;
        flashCounter = flashLength;
    }

    public void SetSpawnPoint(Vector3 newPosition)
    {
        respawnPoint = newPosition;
    }
}
