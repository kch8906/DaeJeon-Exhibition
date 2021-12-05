using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playanimG : MonoBehaviour {

	public Button button;

	public Rigidbody rb;

	public Animator ani;

	void Start () {



		rb = GetComponent<Rigidbody> ();

		button.onClick.AddListener (() => {

			//GetComponent<Animator> ().Play ("TRANS");

			StartCoroutine("Next");

		});
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Next()
	{
		yield return new WaitForSeconds (12);

		ani.speed = 0.0f;

		//GetComponent<Animator> ().Play ("TRANS");

		rb.isKinematic = false;
	}
}
