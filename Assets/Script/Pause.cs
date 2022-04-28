using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Pause : MonoBehaviour
{
    public bool paused;
    public GameObject Pauser;
    public GameObject UnPause;
    public virtual void Start()
    {
        this.UnPause.SetActive(false);
        Time.timeScale = 1;
    }

    public virtual void pause()
    {
        if (this.paused == false)
        {
            Debug.Log("Pausing...");
            this.paused = true;
            Time.timeScale = 0;
            this.Pauser.SetActive(false);
            this.UnPause.SetActive(true);
        }
        else
        {
            if (this.paused == true)
            {
                Debug.Log("Pausing...");
                this.paused = false;
                Time.timeScale = 1;
                this.UnPause.SetActive(false);
                this.Pauser.SetActive(true);
            }
        }
    }

    public virtual void MainMenu()
    {
        Application.LoadLevel("MainMenu");
    }

}
