using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour
{

    public List<GameObject> attachedBodies;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "CanScale")
        {
            attachedBodies.Add(collision.gameObject);
            collision.gameObject.AddComponent<FixedJoint>();
            collision.gameObject.GetComponent<FixedJoint>().connectedBody = this.gameObject.GetComponent<Rigidbody>(); ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
