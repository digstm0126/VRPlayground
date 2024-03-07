using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KickController : MonoBehaviour
{
    public GameObject winTextdesplayBall;

    // Start is called before the first frame update
    void Start()
    {
        winTextdesplayBall.SetActive(false);
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
        if (other.tag == "ball") {

            Debug.Log("hiii");
            winTextdesplayBall.SetActive(true);
        }
    }
}
