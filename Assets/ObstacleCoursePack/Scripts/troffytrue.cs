using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class troffytrue : MonoBehaviour
{
    private IXRSelectInteractable item;
    public bool itemSelected = false;
    public void ItemAdded()
    {
        item = GetComponent<XRSocketInteractor>().GetOldestInteractableSelected();
        itemSelected = true;
    }

   public void ItemRemoved()
    {
        item = null;
        itemSelected = false;
    }
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
