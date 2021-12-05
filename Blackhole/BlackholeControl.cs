using UnityEngine;
using System.Collections;

public class BlackholeControl : MonoBehaviour {

	public float gravity = 15.0f;
	public float planeDrag = 5.0f;
	public float outerRadius = 15.0f;
	public float innerRadius = 1.0f;


	void Update () 
	{
		Collider[] objects = Physics.OverlapSphere (transform.position, outerRadius);
		foreach (Collider col in objects)
		{
			if (Vector3.Distance (transform.position, col.transform.position) > innerRadius)
			{
				if (col.GetComponent<Rigidbody> ()) 
				{
					Rigidbody r = col.GetComponent<Rigidbody> ();
					r.drag = planeDrag;
					r.AddForce (gravity * (transform.position - col.transform.position).normalized, ForceMode.Impulse);
				}
			}
		}
	
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, outerRadius);
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere (transform.position, innerRadius);
	}
}
