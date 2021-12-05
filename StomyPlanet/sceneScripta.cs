using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneScripta : MonoBehaviour {

	public Button ar;




	// Use this for initialization
	void Start () {
		ar.onClick.AddListener (() => {
			SceneManager.LoadScene ("다른공전");
		});


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
