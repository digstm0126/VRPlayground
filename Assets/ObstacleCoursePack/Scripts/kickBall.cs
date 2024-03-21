using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kickBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;

        if (Physics.Raycast(transform.position, fwd, out hit, 10))
        {
            if (hit.collider.tag == "ball")
            {
                Debug.Log("BAAAALLL");
                hit.rigidbody.AddForce(fwd * 100);

            }
            
        }
              
    }
}
