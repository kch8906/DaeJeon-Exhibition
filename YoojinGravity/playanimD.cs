using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playanimD : MonoBehaviour {

	public Button button;

	public Rigidbody rb;
	Animator ani;


	void Awake ()
	{
		ani = GetComponent<Animator> ();

	}
	void Start () 
	{

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
		yield return new WaitForSeconds (6);

		if (ani.GetCurrentAnimatorStateInfo (0).fullPathHash == Animator.StringToHash ("Base Layer.GRAV"))
		{
			ani.CrossFade ("TRANS", 0.2f);
		}

		rb.isKinematic = false;
	}


}

