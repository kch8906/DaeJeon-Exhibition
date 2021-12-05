using UnityEngine;
using System.Collections;

public class Clone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		StartCoroutine ("Destroy");
	
	}

	IEnumerator Destroy ()
	{
		yield return new WaitForSeconds (3);
		if (gameObject.name == "pt(Clone)") {
			Destroy (this.gameObject);
		}
	}
}
