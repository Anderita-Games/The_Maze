#pragma strict
public var Winning : GameObject;
var Speed = .1;

function Start () {
	Winning.SetActive (false);
}

function Update() {
	//Computer Version
	if (Input.GetKey ("right")) {
		transform.Rotate(Vector3.up * Speed * 2);
	}
	if (Input.GetKey ("left")) {
		transform.Rotate(Vector3.up * (Speed * -2));
	}
	if (Input.GetKey ("up")) {
		transform.Translate(Vector3.forward * (Speed * .1));
	}
	if (Input.GetKey ("down")) {
		transform.Translate(Vector3.forward * (Speed * -.1));
	}
	if (Input.GetKey ("space")) {
		transform.Translate(Vector3.up * (Speed * 1));
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
		Winning.SetActive (true);
	}
}

function OnGui () {
	GUI.skin.box.fontSize = Screen.width/80;
	GUI.Box (new Rect (0, 0, Screen.width/6, Screen.height/16), "Time Wasted: " + Time.timeSinceLevelLoad);
}