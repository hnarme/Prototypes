using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    public GameManager gameManager;
    public MoveForward moveForward;

    public int maxHealth = 3;
    public int currentHealth;

    public GameObject player;
    public GameObject weapon;
    public GameObject pButton;
    public GameObject enemies;

    public float InvincibilityLength;
    private float InvincibilityCounter;

    public Renderer weaponRenderer;
    private float flashCounter;
    private float flashLength = 0.1f;

    public Vector3 respawnPoint;
    public bool isRespawning;
    public float respawnLength;

    public Image blackScreen;
    private bool isFadeToBlack;
    private bool isFadeFromBlack;
    public float fadeSpeed;
    public float waitForFade;

    public HealthBar healthBar;


    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        healthBar = FindObjectOfType<HealthBar>();

        enemies = GameObject.FindGameObjectWithTag("Enemy");

        respawnPoint = player.transform.position;

        currentHealth = maxHealth;

        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (InvincibilityCounter > 0)
        {
            InvincibilityCounter -= Time.deltaTime;

            flashCounter -= Time.deltaTime;

            if (flashCounter <= 0)
            {
                weaponRenderer.enabled = !weaponRenderer.enabled;
                flashCounter = flashLength;
            }

            if (InvincibilityCounter <= 0)
            {
                weaponRenderer.enabled = true;
            }
        }

        if (isFadeToBlack)
        {
            blackScreen.color = new Color(blackScreen.color.r, blackScreen.color.g, blackScreen.color.b, Mathf.MoveTowards(blackScreen.color.a, 1f, fadeSpeed * Time.deltaTime));
            if (blackScreen.color.a == 1f)
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

        if (currentHealth <= 0)
        {
            StartRespawn();
        }
    }

    public void TakeDamage()
    {
        currentHealth--;
        healthBar.SetHealth(currentHealth);
    }

    public void StartRespawn()
    {
        if (!isRespawning)
        {
            StartCoroutine("RespawnCo");
        }
    }

    public IEnumerator RespawnCo()
    {
        isRespawning = true;

        currentHealth = maxHealth;
        healthBar.SetHealth(currentHealth);

        weapon.gameObject.SetActive(false);
        pButton.gameObject.SetActive(false);

        yield return new WaitForSeconds(respawnLength);

        isFadeToBlack = true;

        yield return new WaitForSeconds(waitForFade);

        isFadeToBlack = false;
        isFadeFromBlack = true;

        isRespawning = false;

        player.transform.position = respawnPoint;

        weapon.gameObject.SetActive(true);
        pButton.gameObject.SetActive(true);

        InvincibilityCounter = InvincibilityLength;
        weaponRenderer.enabled = false;
        flashCounter = flashLength;
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            currentHealth--;
            healthBar.SetHealth(currentHealth);
        }
    }
}
