using UnityEngine;
using System.Collections;

public class destroyPiece : MonoBehaviour {

	void OnTriggerEnter(Collider co)
	{
		if (co.gameObject.CompareTag("Right")) {
			Destroy(co.gameObject);
		}
	}
}
