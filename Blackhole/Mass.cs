using UnityEngine;
using System.Collections;

public class Mass : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "mass") 
		{
			rb.mass = 1200;
		}
	}
}
