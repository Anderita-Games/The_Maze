using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Tutorial : MonoBehaviour
{
    //The tutorial Stuff
    public GameObject Nub;
    public GameObject Nub2;
    public GameObject Forward;
    public GameObject Turn;
    public GameObject Win;
    //Control
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

    public virtual void OnTriggerEnter(Collider info)
    {
        if (info.name == "Nub")
        {
            this.Forward.SetActive(false);
            this.Nub.SetActive(false);
            this.Turn.SetActive(true);
        }
        if (info.name == "Nub2")
        {
            this.Turn.SetActive(false);
            this.Nub2.SetActive(false);
            this.Win.SetActive(true);
        }
        if (info.name == "Yellow")
        {
            Application.LoadLevel("MainMenu");
        }
    }

    public Tutorial()
    {
        this.Speed = 0.1f;
    }

}