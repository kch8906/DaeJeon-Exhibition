using UnityEngine;
using System.Collections;

public class TouchMoveMent : MonoBehaviour {

	public Vector3 pos;

	// Use this for initialization
	void Start () {

		MoveUpdate ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void MoveUpdate ()
	{
		if (Application.platform == RuntimePlatform.Android) {
			//pos = Camera.main.ScreenToWorldPoint (Vector3 (Input.GetTouch (0).position.x, Input.GetTouch (0).position.y, 1));
		} 
		else
		{
			//pos = Camera.main.ScreenToWorldPoint (Vector3 (Input.mousePosition.x, Input.mousePosition.y, 1));
		}

		transform.position = new Vector3 (pos.x, pos.y + 1f, pos.z);
	}
}
