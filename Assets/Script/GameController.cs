using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	// UI Components
	public Text hintText;
	public InputField InputField;
	public Text levelText;

	// Normal variables
	public string levelAnswer;
	public string levelNumber;
	public string levelHint;
	public string nextScene;
	public string hintScene;



	// Use this for initialization
	void Start () {
		hintText.text = levelHint;

	}

	public void checkAnswer(){
		if (InputField.text == levelAnswer) {
			// TODO : Change Scene
			hintText.text = "good blow job";
			hintText.color = Color.green;
			SceneManager.LoadScene (nextScene);
		} else {
			hintText.text = "ACCESS DENIED!!!";
			hintText.color = Color.red;
			InputField.text = "";
			InputField.ActivateInputField ();

		}
	}
	// Update is called once per frame
	void Update () {
		
	}
	public void nextButton(){
		SceneManager.LoadScene (hintScene);
	}
}

