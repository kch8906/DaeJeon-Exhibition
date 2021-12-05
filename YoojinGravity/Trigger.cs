using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Trigger : MonoBehaviour {


	public Button Gravity;
	public Button Reset;

	public Vector3 speed;




	void Awake()
	{
		
	}

	void Start ()
	{

		Gravity.onClick.AddListener (() => {

			Physics.gravity = new Vector3 (0 , 0.1f, 0);





		});

		Reset.onClick.AddListener (() => {

			SceneManager.LoadScene("2");

			Physics.gravity = new Vector3 (0 , -0.1f, 0);
		});
	
	}
	

	void Update () {
	
	}




}
