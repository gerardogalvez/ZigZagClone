using UnityEngine;
using System.Collections;

public class startScore : MonoBehaviour {
	
	public static bool startCountScore = false;
	// Use this for initialization
	void Start () {
		startCountScore = false;
	}
	
	void OnTriggerEnter(Collider col)
	{
		if (col.CompareTag("Player")) {
			startCountScore = true;
		}
	}
}
