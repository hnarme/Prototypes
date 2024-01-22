using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
	public GameObject tutorialCutsceneCam1;
	public GameObject tutorialCutsceneCam2;
	public GameObject tutorialCutsceneCam3;
	public GameObject tutorialCutsceneCam4;
	public GameObject tutorialCutsceneCam5;
	public GameObject tutorialCutsceneCam6;

	public GameObject cam1Text;
	public GameObject cam3Text;
	public GameObject cam4Text;
	public GameObject cam5Text;
	public GameObject cam41Text;
	public GameObject cam51Text;
	public GameObject cam42Text;

	public AudioSource townPanicAudio;

	public GameObject grandpa;
	public GameObject barrier;
	public GameObject cutSceneTrigger2;
	public GameObject cutSceneTrigger1;
	public GameObject cutSceneTrigger3;
	public GameObject activeSkeleton;
	public GameObject inactiveSkeleton;

	public Animator grandpaAnimation;
	public bool isTalking;


	// Start is called before the first frame update
	void Start()
    {

	}

    void Update()
    {
		grandpaAnimation.SetBool("isTalking", isTalking);
	}

    //Player finds a portal and hears the village panicking
    IEnumerator LoadTutorialCutscene1()
	{
		cutSceneTrigger2.SetActive(true);
		// camera position player and portal with text
		tutorialCutsceneCam1.SetActive(true);
		cam1Text.SetActive(true);

		yield return new WaitForSeconds(5);
		tutorialCutsceneCam1.SetActive(false);
		cam1Text.SetActive(false);

		// start town screaming audio with face cam
		townPanicAudio.Play();
		tutorialCutsceneCam2.SetActive(true);

		yield return new WaitForSeconds(2);
		tutorialCutsceneCam2.SetActive(false);

		// town camera and text
		tutorialCutsceneCam3.SetActive(true);
		cam3Text.SetActive(true);

		yield return new WaitForSeconds(3);
		tutorialCutsceneCam3.SetActive(false);
		cam3Text.SetActive(false);

		grandpa.SetActive(true);
		barrier.SetActive(true);
		cutSceneTrigger1.SetActive(false);
	}

	//Grandpa meets player and warns them not to be a hero
	IEnumerator LoadTutorialCutscene2()
	{
		cutSceneTrigger3.SetActive(true);
		// camera position grandpa with text
		tutorialCutsceneCam4.SetActive(true);
		isTalking = true;
		cam4Text.SetActive(true);

		yield return new WaitForSeconds(5);
		tutorialCutsceneCam4.SetActive(false);
		cam4Text.SetActive(false);

		// camera position player with text
		tutorialCutsceneCam5.SetActive(true);
		cam5Text.SetActive(true);

		yield return new WaitForSeconds(5);
		tutorialCutsceneCam5.SetActive(false);
		cam5Text.SetActive(false);

		// camera position grandpa with text
		tutorialCutsceneCam4.SetActive(true);
		cam41Text.SetActive(true);

		yield return new WaitForSeconds(5);
		tutorialCutsceneCam4.SetActive(false);
		cam41Text.SetActive(false);

		// camera position player with text
		tutorialCutsceneCam5.SetActive(true);
		cam51Text.SetActive(true);

		yield return new WaitForSeconds(2);
		tutorialCutsceneCam5.SetActive(false);
		cam51Text.SetActive(false);

		// camera position grandpa with text
		tutorialCutsceneCam4.SetActive(true);
		cam42Text.SetActive(true);

		yield return new WaitForSeconds(5);
		tutorialCutsceneCam4.SetActive(false);
		cam42Text.SetActive(false);
		isTalking = false;

		cutSceneTrigger2.SetActive(false);
		inactiveSkeleton.SetActive(true);
		activeSkeleton.SetActive(true);
	}

	//Shows the last to enemies going into the portal
	IEnumerator LoadTutorialCutscene3()
	{
		// camera position skeleton walking into portal
		tutorialCutsceneCam6.SetActive(true);

		yield return new WaitForSeconds(5);
		tutorialCutsceneCam6.SetActive(false);

		cutSceneTrigger3.SetActive(false);
	}

	public void TutorialCutscene1()
    {
		StartCoroutine(LoadTutorialCutscene1());
    }

	public void TutorialCutscene2()
	{
		StartCoroutine(LoadTutorialCutscene2());
	}

	public void TutorialCutscene3()
	{
		StartCoroutine(LoadTutorialCutscene3());
	}
}
