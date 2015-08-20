using UnityEngine;
using System.Collections;

public class createPiece : MonoBehaviour {

	private Vector3 prevPosition;
	public GameObject rigth;
	public GameObject previous;
	private Vector3 newPosition;
	private int nextPiece;
	public int[] arr = new int[4];
	public int cont = 0;

	// Use this for initialization
	void Start () {
		prevPosition = previous.transform.position;
		arr [0] = 1;
		arr [1] = 1;
		arr [2] = 1;
		arr [3] = 1;
	}

	//Detect when a platform must be created
	void OnTriggerEnter(Collider co)
	{

		if (co.gameObject.CompareTag("Right")) {
			nextPiece = Random.Range (1, 3);

			//Don't let a same piece spawn 4 times in a row
			cont = cont%4;
			arr[cont] = nextPiece;
			if (arr[0] == 1 && arr[1]==1 && arr[2]==1 && arr[3]==1)
			{
				nextPiece = 2;
				arr[cont] = 2;
			}
			else if (arr[0] == 2 && arr[1]==2 && arr[2]==2 && arr[3]==2)
			{
				nextPiece = 1;
				arr[cont] = 1;
			}
			craftPiece (nextPiece, Mathf.FloorToInt(previous.transform.eulerAngles.y));
			cont++;
		}
	}

	//Creates a platform
	void craftPiece(int nextPiece, int rotationY){
		//Next platform will face right
		if (nextPiece == 1) {
			//Previous platform is facing right
			if (rotationY == 45){
			newPosition = new Vector3 (prevPosition.x += 10.25f, -7, prevPosition.z += 10.25f);
			previous = (GameObject)Instantiate (rigth, newPosition, Quaternion.Euler (0, 45, 0));
			}
			//Previous platform is facing left
			else if (rotationY == 315) {
				newPosition = new Vector3 (prevPosition.x -= 2.97f, -7, prevPosition.z += 10.28f);
				previous = (GameObject)Instantiate (rigth, newPosition, Quaternion.Euler (0, 45, 0));
			} 
		}
		//Next platform will face left
		else if (nextPiece == 2) {
			//Previous platform is facing right
			if (rotationY == 45){
			newPosition = new Vector3 (prevPosition.x += 2.97f, -7, prevPosition.z += 10.28f);
			previous = (GameObject)Instantiate (rigth, newPosition, Quaternion.Euler (0, -45, 0));
			}
			//Previous platform is facing left
			else if (rotationY == 315) {
				newPosition = new Vector3 (prevPosition.x -= 10.25f, -7, prevPosition.z += 10.25f);
				previous = (GameObject)Instantiate (rigth, newPosition, Quaternion.Euler (0, -45, 0));
			}
		}
	}
}
