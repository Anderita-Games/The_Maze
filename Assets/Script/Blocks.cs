using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Blocks : MonoBehaviour
{
    public bool paused;
    public Transform target;
    public float Speed;
    public bool deez;
    public virtual IEnumerator Start()
    {
        this.gameObject.SetActive(true);
        this.deez = false;
        this.paused = false;
        while (true)
        {
            int number = Random.Range(1, 10);
            Debug.Log(this.paused);
            if ((number == 1) && (this.paused == false))
            {
                if (this.deez == true)
                {
                    this.transform.Translate(Vector3.down * 11);
                    this.deez = false;
                    Debug.Log("Delete it!");
                }
                else
                {
                    if (this.deez == false)
                    {
                        this.transform.Translate(Vector3.up * 11);
                        this.deez = true;
                        Debug.Log("Resurect it!");
                    }
                    else
                    {
                        Debug.Log("Shit gone wrong");
                    }
                }
            }
            yield return new WaitForSeconds(10);
        }
    }

    public virtual void Update()
    {
    }

    public virtual void OnTriggerEnter(Collider info)
    {
        if (info.name == "Sphere")
        {
            this.paused = true;
        }
    }

    public Blocks()
    {
        this.Speed = 0.1f;
    }

}
