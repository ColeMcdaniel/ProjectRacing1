using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public int LevelToLoad;

	public void ClickedStartButton()
	{
		SceneManager.LoadScene (3);
	}

	public void HowToPlayButton()
	{
		SceneManager.LoadScene (1);
	}

	public void CreditsButton()
	{
		SceneManager.LoadScene (2);
	}

	public void BackToMainMenu ()
	{
		SceneManager.LoadScene (0);
	}

	public void doquit () 
	{
		Debug.Log ("Has quit Game");
		Application.Quit(); 
	}

}