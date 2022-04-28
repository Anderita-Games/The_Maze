using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class MainMenu : MonoBehaviour
{
    public float Speed;
    public virtual void Update()//other stuff
    {
        //Computer Version
        if (Input.GetKey("right"))
        {
            this.transform.Rotate((Vector3.up * this.Speed) * 20);
        }
        if (Input.GetKey("left"))
        {
            this.transform.Rotate(Vector3.up * (this.Speed * -20));
        }
        if (Input.GetKey("up"))
        {
            this.transform.Translate(Vector3.forward * (this.Speed * 1));
        }
        if (Input.GetKey("down"))
        {
            this.transform.Translate(Vector3.forward * (this.Speed * -1));
        }
        //Phone Version
        this.transform.Rotate((Vector3.up * Input.acceleration.x) * 8);
        this.transform.Translate((Vector3.forward * -Input.acceleration.z) * 0.2f);
    }

    public virtual void Tutorial()
    {
        Application.LoadLevel("Tutorial");
    }

    public virtual void Level1()
    {
        Application.LoadLevel("Level1");
    }

    public virtual void QuitGame()
    {
        Debug.Log("Game is exiting...");
        Application.Quit();
    }

    public MainMenu()
    {
        this.Speed = 0.1f;
    }

}