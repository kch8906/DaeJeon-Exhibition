using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneScript : MonoBehaviour {


	public Button vr;



	// Use this for initialization
	void Start () {
		
		vr.onClick.AddListener (() => {
			SceneManager.LoadScene ("vr2번");
		});
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
