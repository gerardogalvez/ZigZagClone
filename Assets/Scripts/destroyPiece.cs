using UnityEngine;
using System.Collections;

public class destroyPiece : MonoBehaviour {

	void OnTriggerEnter(Collider co)
	{
		if (co.gameObject.tag == "Right") {
			Destroy(co.gameObject);
		}
	}
}
