using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BASKETBALLontroler : MonoBehaviour
{
    public GameObject winTextdesplaybasketball;
    public GameObject TROFY;

    // Start is called before the first frame update
    void Start()
    {
        winTextdesplaybasketball.SetActive(false);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BASKETBALL") {

            Debug.Log("BAYE");
            winTextdesplaybasketball.SetActive(true);
            TROFY.SetActive(true);
        }
    }
}
