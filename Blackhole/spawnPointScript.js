var object : Transform;
var spawnPoint : Transform;


function Update () {
	if(Input.touchCount > 0 || Input.GetKey(KeyCode.Mouse0))
	{
		Instantiate(object.transform, spawnPoint.position, spawnPoint.rotation);
	}

}