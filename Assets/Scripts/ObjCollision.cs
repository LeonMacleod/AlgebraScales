using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnCollisionEnter(Collision collision) {
        // is colliding with scale, do nothing
        if(collision.gameObject.tag == "CanScale")
        {
            // oobjects that are not in collision with the scale object.
            if (!(scale.attachedBodies.Contains(collision.gameObject)))
            {
                //Objects not directly touching scale (adding mass) have their masses added anyway.
                scale.attachedBodies.Add(collision.gameObject);
            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
