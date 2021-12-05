using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playanim : MonoBehaviour {

	public Button button;

	public Rigidbody rb;

	void Start () {

		rb = GetComponent<Rigidbody> ();

		button.onClick.AddListener (() => {

			GetComponent<Animator> ().Play ("TRANS");

		});
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
