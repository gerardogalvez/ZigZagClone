using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreGotten : MonoBehaviour {
	public static int highscore;
	public Text highscoreText;

	void Awake(){
		highscore = 0;
	}

	// Use this for initialization
	void Start () {
		//highscore = PlayerPrefs.GetInt ("Highscore", 0);
		highscoreText.text = "Highscore: " + highscore.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerMovement.score > highscore) {
			//PlayerPrefs.SetInt("Highscore", PlayerMovement.score);
			//PlayerPrefs.Save();
			highscore = PlayerMovement.score;
		}
		//highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore").ToString();
		highscoreText.text = "Highscore: " + highscore.ToString();
	}
}
