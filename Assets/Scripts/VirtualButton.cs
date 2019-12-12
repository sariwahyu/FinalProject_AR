using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vbButtonObject;

    void Start()
    {
        vbButtonObject = GameObject.Find("actionButton");
        vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler(this);
    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed!");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    
}