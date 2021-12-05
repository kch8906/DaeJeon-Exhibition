using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RigidBodyController : MonoBehaviour {

	public Button Gravity;
	public Button Reset;

	public GameObject capsule;

	public Vector3 speed;


	void Start () {

		Gravity.onClick.AddListener (() => {

			//this.transform.Rotate(Vector3.up,Space.Self);

			transform.Rotate(speed * Time.deltaTime);

			//capsule.SetActive(false);
			//this.transform.GetComponent<Rigidbody>().AddForce(Vector3.up * 500 * Time.deltaTime);
			Physics.gravity = new Vector3 (0, 0.1f, 0);

			//Physics.gravity = Vector3.up;




		});

		Reset.onClick.AddListener (() => {

			//Application.LoadLevel(Application.loadedLevel);

			SceneManager.LoadScene("reset");
			//SceneManager.UnloadScene("reset");
			Physics.gravity = Vector3.down;

			//Physics.gravity = new Vector3 (0, 0.1f, 0);


		});
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.UpArrow))
			{
				this.transform.GetComponent<Rigidbody>().AddForce(Vector3.forward * 300 * Time.deltaTime);
			}


		if(Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.GetComponent<Rigidbody>().AddForce(Vector3.back * 300 * Time.deltaTime);
		}


		if(Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.GetComponent<Rigidbody>().AddForce(Vector3.right * 300 * Time.deltaTime);
		}


		if(Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.GetComponent<Rigidbody>().AddForce(Vector3.left * 300 * Time.deltaTime);
		}


		if(Input.GetKey(KeyCode.W))
		{
			this.transform.GetComponent<Rigidbody>().AddForce(Vector3.up * 500 * Time.deltaTime);
		}


		if(Input.GetKey(KeyCode.D))
		{
			this.transform.GetComponent<Rigidbody>().AddForce(Vector3.down * 500 * Time.deltaTime);
		}


		if (Input.GetKey (KeyCode.Keypad0)) 
		{
			Physics.gravity = Vector3.zero;
		}

		if (Input.GetKey (KeyCode.Keypad8)) 
		{
			Physics.gravity = Vector3.up;
		}

		if (Input.GetKey (KeyCode.Keypad2)) 
		{
			Physics.gravity = Vector3.down;
		}



	
	}
}
