using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Audio;

public class MenuManager : MonoBehaviour
{
    public bool isGamePaused = false;

    public bool isSettingsActive = false;

    public bool isVsyncOn = false;

    public bool isFullScreenOn = false;

    public GameObject PauseMenuUI;

    public GameObject MainMenuUI;

    public GameObject SettingsMenuUI;

    public Toggle VsyncToggle;

    public Toggle FullscreenToggle;

    public CameraController cameraController;

    public List<ResItem> resolutionItems = new List<ResItem>();

    private int selectedResolution;

    public TMP_Text resolutionLabel;

    public bool musicToggle = true;

    public AudioSource BackgroundMusic;

    public AudioMixerGroup Sound;

    public GameObject miniMap;

    public LevelIdentifier levelIdentifier;
    public LevelLoader levelLoader;
    public HealthManager healthManager;
    public PlayerController playerController;
    public EnemyHealthManager enemyHealthManager;
    public EnemyController enemyController;
    //private EnemyHealthManager[] enemyHealthManagerArr;
    //private EnemyController[] enemyControllerArr;
    //private GameObject[] enemy;
    public int level = 0;
    int playerHealth;
    int enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        levelIdentifier = FindObjectOfType<LevelIdentifier>();
        healthManager = FindObjectOfType<HealthManager>();
        playerController = FindObjectOfType<PlayerController>();
        enemyHealthManager = FindObjectOfType<EnemyHealthManager>();
        enemyController = FindObjectOfType<EnemyController>();

        playerHealth = healthManager.currentHealth;
        level = levelIdentifier.level;


        bool foundRes = false;
        for (int i = 0; i < resolutionItems.Count; i++)
        {
            if (Screen.width == resolutionItems[i].horizontal && Screen.height == resolutionItems[i].vertical)
            {
                foundRes = true;

                selectedResolution = i;

                UpdateResLabel();
            }
        }

        if (!foundRes)
        {
            ResItem newRes = new ResItem();
            newRes.horizontal = Screen.width;
            newRes.vertical = Screen.height;

            resolutionItems.Add(newRes);
            selectedResolution = resolutionItems.Count - 1;

            UpdateResLabel();
        }
    }

    // Update is called once per frame
    void Update()
    {

        //enemy = GameObject.FindGameObjectsWithTag("Enemy");

        UpdateResLabel();

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (isSettingsActive)
        {
            MainMenuUI.SetActive(false);
        }
        else
        {
            isSettingsActive = false;
            SettingsMenuUI.SetActive(false);
            MainMenuUI.SetActive(true);
        }

        if (FullscreenToggle.isOn && isFullScreenOn)
        {
            Screen.fullScreen = true;
        }
        else
        {
            isFullScreenOn = false;
            Screen.fullScreen = false;
        }

        if (VsyncToggle.isOn && isVsyncOn)
        {
            QualitySettings.vSyncCount = 0;
        }
        else
        {
            isVsyncOn = false;
            QualitySettings.vSyncCount = 1;
        }
    }

    public void SaveGame()
    {
        SaveSystem.Save(levelIdentifier, playerController, healthManager, enemyController, enemyHealthManager);

        Debug.Log("Game Saved");
    }

    public void LoadGame()
    {
        SaveData LoadData = SaveSystem.Load();

        level = LoadData.level;

        if (level == 0)
        {
            levelLoader.Tutorial();
        }
        else if (level == 1)
        {
            levelLoader.Level1();
        }
        else if (level == 2)
        {
            levelLoader.Level2();
        }
        else if (level == 3)
        {
            levelLoader.Level3();
        }
        else if (level == 4)
        {
            levelLoader.Level4();
        }

        playerHealth = LoadData.playerHealth;
        enemyHealth = LoadData.enemyHealth;

        Vector3 playerPosition;
        playerPosition.x = LoadData.playerPosition[0];
        playerPosition.y = LoadData.playerPosition[1];
        playerPosition.z = LoadData.playerPosition[2];
        playerController.transform.position = playerPosition;

        Vector3 enemyPosition;
        enemyPosition.x = LoadData.enemyPosition[0];
        enemyPosition.y = LoadData.enemyPosition[1];
        enemyPosition.z = LoadData.enemyPosition[2];
        gameObject.transform.position = enemyPosition;

        Debug.Log("Game Loaded");
    }

    public void ResLeft()
    {
        selectedResolution--;
        if (selectedResolution < 0)
        {
            selectedResolution = 0;
        }

        UpdateResLabel();
    }

    public void ResRight()
    {
        selectedResolution++;
        if (selectedResolution > resolutionItems.Count - 1)
        {
            selectedResolution -= resolutionItems.Count - 1;
        }

        UpdateResLabel();
    }

    public void UpdateResLabel()
    {
        resolutionLabel.text = resolutionItems[selectedResolution].horizontal.ToString() + " x " + resolutionItems[selectedResolution].vertical.ToString();
    }

    public void Resume()
    {
        miniMap.SetActive(true);
        PauseMenuUI.SetActive(false);
        SettingsMenuUI.SetActive(false);
        Time.timeScale = 1;
        isGamePaused = false;
    }

    public void Pause()
    {
        miniMap.SetActive(false);
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        isGamePaused = true;
    }

    //Menu Button Handlers
    public void ButtonHandlerPlay()
    {
        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadTutorialScene());
    }

    public void ButtonHandlerResume()
    {
        Resume();
    }

    public void ButtonHandlerMainMenu()
    {
        // Use a coroutine to load the Scene in the background
        StartCoroutine(LoadMenuScene());
    }

    public void ButtonHandlerSettings()
    {
        isSettingsActive = true;
        SettingsMenuUI.SetActive(true);
    }

    public void ButtonHandlerSettingsBack()
    {
        isSettingsActive = false;
        SettingsMenuUI.SetActive(false);
    }

    public void ButtonHandlerQuit()
    {
        SaveGame();
        Application.Quit();
    }

    //Settings Items
    public void SettingsFullscreenToggle()
    {
        isFullScreenOn = true;
    }

    public void SettingsVsyncToggle()
    {
        isVsyncOn = true;
    }

    public void SettingsApplyResolution()
    {
        Screen.SetResolution(resolutionItems[selectedResolution].horizontal, resolutionItems[selectedResolution].vertical, isFullScreenOn);
    }

    public void InvertYToggle()
    {
        if (cameraController.invertY == true)
        {
            cameraController.invertY = false;
        }
        else if (cameraController.invertY == false)
        {
            cameraController.invertY = true;
        }

    }

    public void SettingsMusicToggle()
    {
        musicToggle = !musicToggle;
        if (musicToggle)
        {
            BackgroundMusic.mute = true;
        }
        else
        {
            BackgroundMusic.mute = false;
        }
    }

    //Level loaders
    IEnumerator LoadMenuScene()
    {
        SaveGame();

        Time.timeScale = 1;

        AsyncOperation MenuLoad = SceneManager.LoadSceneAsync("Menu");

        // Wait until the asynchronous scene fully loads
        while (!MenuLoad.isDone)
        {
            yield return null;
        }
    }

    IEnumerator LoadTutorialScene()
    {
        Time.timeScale = 1;

        AsyncOperation tutorialLoad = SceneManager.LoadSceneAsync("Tutorial - Town");

        // Wait until the asynchronous scene fully loads
        while (!tutorialLoad.isDone)
        {
            yield return null;
        }
    }
}

[System.Serializable]
public class ResItem
{
    public int horizontal, vertical;
}
