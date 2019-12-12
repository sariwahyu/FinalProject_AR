using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbInteraction : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    public GameObject firstPanel, secondPanel, crocodile, bridge;

    void Start()
    {
        virtualButtonBehaviours = GetComponentsInParent<VirtualButtonBehaviour>();
        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
        {
            virtualButtonBehaviours[i].RegisterEventHandler(this);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;

        if (vbName == "VirtualButtonChange")
            VirtualButtonChange();
        else if(firstPanel.activeInHierarchy)
        {
            Deactive();
            if (vbName == "VirtualButton1")
            {
                Btn1();
            }
            else if(vbName == "VirtualButton2")
            {
                Btn2();
            }
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        throw new System.NotImplementedException();
    }

    void VirtualButtonChange()
    {
        if (firstPanel.activeInHierarchy)
        {
            firstPanel.SetActive(false);
            secondPanel.SetActive(true);
        }
        else
        {
            firstPanel.SetActive(true);
            secondPanel.SetActive(false);
        }
    }

    void Deactive()
    {
        crocodile.SetActive(false);
        bridge.SetActive(false);
    }

    void Btn1()
    {
        crocodile.SetActive(true);
    }
    void Btn2()
    {
        bridge.SetActive(true);
    }
}

