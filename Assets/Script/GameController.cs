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

	public List<GameObject> listImage;
	public Button NextButton;

	private int hintCurrentIndex = 0;



	// Use this for initialization
	void Start () {
		hintText.text = levelHint;
		StartCoroutine (ChangeTextLevelCoroutine ());
	}

	IEnumerator ChangeTextLevelCoroutine(){
	
		while (true) {
			yield return new WaitForSeconds (2f);
			levelText.text = levelNumber;
			yield return new WaitForSeconds (2f);
			levelText.text = "LEVELS";
		}
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


	public void OnHintButtonClick(){
		hintCurrentIndex += 1;

		if (hintCurrentIndex == listImage.Count - 1) {
			NextButton.transform.localScale = 
				new Vector3 (-1, 1, 1);
		} else {
			NextButton.transform.localScale = 
				new Vector3 (1, 1, 1);
		}

		if (hintCurrentIndex == listImage.Count) {
			hintCurrentIndex = 0;
		}
		for (int i = 0; i < listImage.Count; i++) {
			if (i == hintCurrentIndex) {
				listImage [i].gameObject.SetActive (true);
			} else {
				listImage [i].gameObject.SetActive (false);
			}
		}			
	}
}

