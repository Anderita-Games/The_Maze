using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Camera : MonoBehaviour
{
    public GameObject Winning;
    public float Speed;
    public virtual void Start()
    {
        this.Winning.SetActive(false);
    }

    public virtual void Update()//other stuff
    {
        //Computer Version
        if (Input.GetKey("right"))
        {
            this.transform.Rotate((Vector3.up * this.Speed) * 2);
        }
        if (Input.GetKey("left"))
        {
            this.transform.Rotate(Vector3.up * (this.Speed * -2));
        }
        if (Input.GetKey("up"))
        {
            this.transform.Translate(Vector3.forward * (this.Speed * 0.1f));
        }
        if (Input.GetKey("down"))
        {
            this.transform.Translate(Vector3.forward * (this.Speed * -0.1f));
        }
        if (Input.GetKey("space"))
        {
            this.transform.Translate(Vector3.up * (this.Speed * 1));
        }
        //Phone Version
        this.transform.Rotate((Vector3.up * Input.acceleration.x) * 8);
        this.transform.Translate((Vector3.forward * -Input.acceleration.z) * 0.2f);
    }

    public virtual void OnTriggerEnter(Collider info)
    {
        if (info.name == "Nub")
        {
            this.Winning.SetActive(true);
        }
    }

    public virtual void OnGui()
    {
        GUI.skin.box.fontSize = Screen.width / 80;
        GUI.Box(new Rect(0, 0, Screen.width / 6, Screen.height / 16), "Time Wasted: " + Time.timeSinceLevelLoad);
    }

    public Camera()
    {
        this.Speed = 0.1f;
    }

}