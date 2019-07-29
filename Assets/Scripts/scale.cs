using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scale : MonoBehaviour
{

    public List<GameObject> attachedBodies;

    public TextMeshPro massText;
    // Start is called before the first frame update
    void Start()
    {
    }


    private float getMass()
    {

        float mass = 0f;

        foreach (GameObject body in attachedBodies)
        {
            mass += body.GetComponent<Rigidbody>().mass;

        }

        return mass;
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

        massText.text = getMass().ToString() + " kg";
        
        
    }
}
