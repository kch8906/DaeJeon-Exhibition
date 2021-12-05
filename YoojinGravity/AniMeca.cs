using UnityEngine;
using System.Collections;

public class AniMeca : MonoBehaviour {

	Animator ani;

	// Use this for initialization
	void Start () {
		
		ani = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("c")) 
		{
			ChangeAni ();
		}
	
	}

	void ChangeAni()
	{
		if (ani.GetCurrentAnimatorStateInfo (0).fullPathHash == Animator.StringToHash ("Base Layer.Take 001"))
		{
			ani.CrossFade ("TRANS", 0.2f);
		}
	}
}
