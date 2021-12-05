using UnityEngine;
using System.Collections;

public class spawnPoint : MonoBehaviour {

	public GameObject[] randomObject;
	public GameObject pt;
	//public GameObject clone;


	void Start () {

		//pt = gameObject.GetComponent<ParticleSystem> ();
		//GameObject clone = (GameObject) Instantiate(pt,transform.position,transform.rotation);


	}
	

	void Update () {

		//int i = 0;
		//GameObject.Destroy (clone);
		/*if(Input.GetKey(KeyCode.Mouse0))
		{
			Instantiate (pt, transform.position, transform.rotation);

			StartCoroutine ("Touch");
			//GameObject.Destroy (clone);
		}*/

		if(Input.touchCount > 0 ){ 
			
			if(Input.GetTouch(0).phase == TouchPhase.Ended){ 
				
				Instantiate (pt, transform.position, transform.rotation);

				StartCoroutine ("Touch");

			} 
		} 



	}





	IEnumerator Touch()
	{
		//if(Input.touchCount > 0 || Input.GetKey(KeyCode.Mouse0))
		//{
		yield return new WaitForSeconds (0.5f);

		Instantiate(randomObject[Random.Range(0, randomObject.Length)], transform.position, transform.rotation);

		//yield return new WaitForSeconds (1);

		//GameObject.Destroy (clone);

		//}
	}

}
