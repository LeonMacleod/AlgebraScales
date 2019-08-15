using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{


    public GameObject scale1;
    public GameObject scale2;




    private void OnCollisionEnter(Collision collision)
    {
        if(!(collision.gameObject.tag == "CanScale"))
        {
            this.gameObject.transform.Find("id").tag = collision.gameObject.name;
        }

        if(collision.gameObject.transform.Find("id").tag == "scale1")
        {
            if (this.gameObject.transform.Find("state").tag == "notadded")
            {
                scale2.GetComponent<scale>().attachedBodies.Add(this.gameObject);
                this.gameObject.transform.Find("state").tag = "added";
                //this.gameObject.transform.Find("id").tag = "scale1";
            }
        }

        if (collision.gameObject.transform.Find("id").tag == "scale2")
        {

            if (this.gameObject.transform.Find("state").tag == "notadded")
            {
                scale2.GetComponent<scale>().attachedBodies.Add(this.gameObject);
                this.gameObject.transform.Find("state").tag = "added";
                //this.gameObject.transform.Find("id").tag = "scale2";
            }
            //scale 2 logic
            

            

        }
    }


    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.transform.Find("id").tag == "scale1")
        {
            //scale 1 logic
            scale1.GetComponent<scale>().attachedBodies.Remove(this.gameObject);
            this.gameObject.transform.Find("state").tag = "notadded";
        }

        if (collision.gameObject.transform.Find("id").tag == "scale1")
        {
            //scale 2 logic
            scale2.GetComponent<scale>().attachedBodies.Remove(this.gameObject);
            this.gameObject.transform.Find("state").tag = "notadded";


        }

    }




    // Start is called before the first frame update
    void Start()
    {
        scale1 = GameObject.Find("scale1");
        scale2 = GameObject.Find("scale2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
