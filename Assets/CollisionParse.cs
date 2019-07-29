using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionParse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void OnCollisionEnter(Collision collision) {
        // is object to go on scale collides with another object
        if(collision.gameObject.tag == "CanScale")
        {
            if (!(scale.attachedBodies.Contains(collision.gameObject)))
            {
                //adding the  masss that never collided directly with the scale
                scale.attachedBodies.Add(collision.gameObject);
            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
