using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalWinText : MonoBehaviour
{
    public GameObject winTextdesplay;
    public GameObject pedastil1;
    public GameObject pedastil2;


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

        if (pedastil1 == true || pedastil2 == true);
            winTextdesplay.SetActive(true); 

    }
}

