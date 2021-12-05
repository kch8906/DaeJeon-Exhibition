using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Test : MonoBehaviour {

	public Button Gravity;

	public Vector3 speed;

	// Use this for initialization
	void Start () {

		Gravity.onClick.AddListener (() => {

			//this.transform.Rotate(Vector3.up,Space.Self);

			transform.Rotate(speed * Time.deltaTime);

			//capsule.SetActive(false);

			//Physics.gravity = Vector3.up;
			Physics.gravity = new Vector3 (0, 0.1f, 0);
		});
	
	}
			
	
	// Update is called once per frame
	void Update () {
	
	}
}
