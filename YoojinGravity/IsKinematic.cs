using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IsKinematic : MonoBehaviour {

	public Button Gravity;

	public Rigidbody rb;


	void Start () {
	
		rb = GetComponent<Rigidbody> ();

		Gravity.onClick.AddListener (() => {

			StartCoroutine("Car");
		});
	}
	

	void Update () {
	
	}

	IEnumerator Car()
	{
		yield return new WaitForSeconds (5);

		rb.isKinematic = false;
	}
}
