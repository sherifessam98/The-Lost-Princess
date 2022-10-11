using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour {

	public AudioSource buttonPress;
	public int bestScore;
	public GameObject bestScoreDisplay;


	void Start()
	{	Cursor.visible = true;
		bestScore = PlayerPrefs.GetInt("LevelScore");
		bestScoreDisplay.GetComponent<Text>().text = "BEST: " + bestScore;

	}

	public void PlayGame()
	{
		buttonPress.Play();
		RedirectToLevel.redirectToLevel = 3;
		SceneManager.LoadScene(2);
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	public void PlayCreds()
	{
		buttonPress.Play();
		SceneManager.LoadScene(4);
	}
}