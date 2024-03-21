using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class Socket : MonoBehaviour
{

    [SerializeField]
    private ActionBasedContinuousMoveProvider cmp;
    public void GrabbedObject()
    {
        // Disable continuous movement when object is selected
        cmp.enabled = false;
    }

    public void ReleasedObject()
    {
        // Enable continuous movement when object is released
        cmp.enabled = true;
    }

}