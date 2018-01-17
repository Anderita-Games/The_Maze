#pragma strict
var Speed = .1;

function Update() {
	//Computer Version
	if (Input.GetKey ("right")) {
		transform.Rotate(Vector3.up * Speed * 20);
	}
	if (Input.GetKey ("left")) {
		transform.Rotate(Vector3.up * (Speed * -20));
	}
	if (Input.GetKey ("up")) {
		transform.Translate(Vector3.forward * (Speed * 1));
	}
	if (Input.GetKey ("down")) {
		transform.Translate(Vector3.forward * (Speed * -1));
	}
	//Phone Version
	transform.Rotate(Vector3.up * Input.acceleration.x * 8);
	transform.Translate(Vector3.forward * -Input.acceleration.z * .20);
	//other stuff
}

function Tutorial()
{
	Application.LoadLevel("Tutorial");
}

function Level1()
{
	Application.LoadLevel("Level1");
}

function QuitGame () 
{
	Debug.Log ("Game is exiting...");
	Application.Quit ();
}