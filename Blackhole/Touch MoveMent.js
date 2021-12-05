private var pos : Vector3;

function Start () {

		Screen.sleepTimeout = SleepTimeout.NeverSleep;
}

function Update () {

	MoveUpdate();

}

function MoveUpdate()
{
	if (Application.platform == RuntimePlatform.Android) {
			pos = Camera.main.ScreenToWorldPoint (Vector3 (Input.GetTouch (0).position.x, Input.GetTouch (0).position.y, 1));
		} 
		else
		{
			pos = Camera.main.ScreenToWorldPoint (Vector3 (Input.mousePosition.x, Input.mousePosition.y, 1));
		}

		transform.position = new Vector3 (pos.x, pos.y , pos.z);
}
