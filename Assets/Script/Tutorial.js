#pragma strict
//The tutorial Stuff
public var Nub : GameObject;
public var Nub2 : GameObject;
public var Forward : GameObject;
public var Turn : GameObject;
public var Win : GameObject;
//Control
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

function OnTriggerEnter (info : Collider)
{
	if (info.name == "Nub")
	{
		Forward.SetActive (false);
		Nub.SetActive (false);
		Turn.SetActive (true);
	}
	if (info.name == "Nub2")
	{
		Turn.SetActive (false);
		Nub2.SetActive (false);
		Win.SetActive (true);
	}
	if (info.name == "Yellow")
	{
	Application.LoadLevel("MainMenu");
	}
}