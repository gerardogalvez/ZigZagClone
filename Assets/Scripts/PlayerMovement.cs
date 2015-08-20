using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private Vector3 movementDirection;
	private float speed = 1;
	public Vector2 startPos;
	public Vector2 endPos;
	public static int score;
	private bool goingLeft = true;
	private bool goingRight = false;
	// Use this for initialization
	void Start () {
		movementDirection = new Vector3 (-1, 0, 1);
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (StartOptions.gameHasStarted) {
			//Debug.Log(score.ToString());
			if (Input.GetKeyDown ("left"))
			{
				movementDirection = new Vector3 (-1, 0, 1);
				if (startScore.startCountScore && goingRight && this.gameObject.tag == "Player")
					score = score + 1;
				goingLeft = true;
				goingRight = false;
			}
			else if (Input.GetKeyDown ("right"))
			{
				movementDirection = new Vector3 (1, 0, 1);
				if (startScore.startCountScore && goingLeft && this.gameObject.tag == "Player")
					score = score + 1;
				goingLeft = false;
				goingRight = true;
			}
			// Get left/right swipe
			/*if (Input.touchCount > 0) {
				var touch = Input.GetTouch(0);

				switch (touch.phase)
				{
				case TouchPhase.Began:
					startPos = touch.position;
					//Debug.Log(startPos.ToString());
					break;
				
				case TouchPhase.Moved:
					endPos = touch.position;
					break;
				
				case TouchPhase.Ended:
					//Debug.Log(endPos.ToString());
					break;
				}
			}

			if (endPos.x > startPos.x && Mathf.Abs(endPos.x - startPos.x) > 25)
				// Right swipe
				movementDirection = new Vector3 (1, 0, 1);
			else
				//Left Swipe
				movementDirection = new Vector3 (-1, 0, 1);*/

			this.transform.Translate (movementDirection * Time.deltaTime * speed);

			if (this.transform.position.y < 0.75f && this.tag == "Player") {
				StartOptions.gameHasStarted = false;
				Destroy(GameObject.Find("UI"));
				Application.LoadLevel (0);
			}

			speed += 0.005f;
		}
	}
}
