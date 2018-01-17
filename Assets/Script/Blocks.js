#pragma strict
var paused;
var target : Transform;
var Speed = .1;
var deez : System.Boolean;
function Start () {
	this.gameObject.SetActive (true);
	deez = false;
	paused = false;
	while(true) {
        var number = Random.Range(1,10);
		Debug.Log (paused);
		if (number == 1 && paused == false) {
			if (deez == true) {
				transform.Translate(Vector3.down * 11);
				deez = false;
				Debug.Log ("Delete it!");
			}
			else if (deez == false) {
				transform.Translate(Vector3.up * 11);
				deez = true;
				Debug.Log ("Resurect it!");
			}
			else {
				Debug.Log ("Shit gone wrong");
			}
		}
	yield WaitForSeconds(10);
    }
}

function Update() {

	
}


function OnTriggerEnter (info : Collider)
{
	if (info.name == "Sphere")
	{
		paused = true;
	}
}
