using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	public Text score;

	// Use this for initialization
	void Start () {
		score.text = "Score: " + PlayerMovement.score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score: " + PlayerMovement.score.ToString ();
	}
}
