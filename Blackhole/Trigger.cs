using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "tt")
		{
			Destroy (other.gameObject);
			Debug.Log ("충돌");
		}	
	}
}
