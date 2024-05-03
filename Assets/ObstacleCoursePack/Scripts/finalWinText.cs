using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class finalWinText : MonoBehaviour
{
    public GameObject winTextdesplay;
    public troffytrue troffyin;
    public troffytrue troffyin2;
    public troffytrue troffyin3;
    

    

    // Start is called before the first frame update
    void Start()
    {
        winTextdesplay.SetActive(false);
        ;
    }



    // Update is called once per frame
    void Update()
    {
 

        if (troffyin.itemSelected == true && troffyin2.itemSelected == true && troffyin3.itemSelected == true)
        {
           winTextdesplay.SetActive(true);
           Debug.Log("final done");
        }
     
    }
    private void OnTriggerEnter(Collider other)
    {
  
    }

    void OnCollisionEnter(Collision collision)
    {

        

    }
}

