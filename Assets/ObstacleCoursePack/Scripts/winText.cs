using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winText : MonoBehaviour
{
    public GameObject winTextdesplay;
    public GameObject troffy;

    // Start is called before the first frame update
    void Start()
    {
        winTextdesplay.SetActive(false);
        //Debug.Log("lol");
    }



    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        if (collision.relativeVelocity.magnitude > 2)
            winTextdesplay.SetActive(true);
            troffy.SetActive(true);
            

    }
}

