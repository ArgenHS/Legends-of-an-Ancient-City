using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour {

	Button startGame;
	Button changeOptions;
	Button exit;
	Canvas mainCanvas;
	Canvas optionsCanvas;
	string selectedMenuItem;

	// Use this for initialization
	void Start () {
		startGame = GameObject.Find("PlayGame").GetComponent<Button>();
		changeOptions = GameObject.Find("OptionsMenu").GetComponent<Button>();
		exit = GameObject.Find("QuitGame").GetComponent<Button>();
		mainCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
		switch (selectedMenuItem)
		{
			case "PlayGame":
				SceneManager.LoadScene(1);
				break;
			case "OptionsMenu":
				mainCanvas.enabled = false;
				break;
			case "QuitGame":
				Application.Quit();
				break;
		}
	}

	void OnClick()
	{
		selectedMenuItem = EventSystem.current.currentSelectedGameObject.name;
	}
}
