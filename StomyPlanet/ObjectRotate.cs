using UnityEngine;
using System.Collections;

public class ObjectRotate : MonoBehaviour {

	public GameObject ObjA;
	public int Speed = 1;

	public float sPeed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//ObjA.transform.Rotate (Vector3.right * Time.deltaTime * Speed);
		ObjA.transform.Rotate (0, sPeed * Time.deltaTime * Speed, 0);
	
	}
}
