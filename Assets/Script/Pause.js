#pragma strict
public var paused : boolean = false;
public var Pause : GameObject;
public var UnPause : GameObject;

function Start() {
	UnPause.SetActive (false);
	Time.timeScale = 1;
}

function pause()
{
	 if (paused == false)
        {
        	Debug.Log ("Pausing...");
            paused = true;
            Time.timeScale = 0;
            Pause.SetActive (false);
			UnPause.SetActive (true);
        }
     else if (paused == true)
        {
        	Debug.Log ("Pausing...");
            paused = false;
            Time.timeScale = 1;
            UnPause.SetActive (false);
			Pause.SetActive (true);
        }
}

function MainMenu () 
{
	Application.LoadLevel("MainMenu");
}