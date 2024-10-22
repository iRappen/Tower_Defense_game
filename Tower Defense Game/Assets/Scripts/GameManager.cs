using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

	public static bool GameIsOver;

	public GameObject gameOverUI;
	public GameObject completeLevelUI;

	void Start ()
	{
		GameIsOver = false;
	}

	void Update () {
		if (GameIsOver)
			return;

		if (PlayerStats.Lives <= 0)
		{
			EndGame();
		}
	}

	void EndGame ()
	{
		GameIsOver = true;
		gameOverUI.SetActive(true);
	}

	public void WinLevel ()
	{
		GameIsOver = true;
		completeLevelUI.SetActive(true);
	}

}
