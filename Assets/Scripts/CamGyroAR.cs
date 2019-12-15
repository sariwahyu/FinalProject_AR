using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamGyroAR : MonoBehaviour
{
    public GameObject webPlane;
    GameObject camParent;

    void Start()
    {
        camParent = new GameObject("CamParent");
        camParent.transform.position = this.transform.position;
        this.transform.parent = camParent.transform;
        camParent.transform.Rotate(Vector3.right, 10);
        Input.gyro.enabled = true;

        WebCamTexture webCamTexture = new WebCamTexture();
        webPlane.GetComponent<MeshRenderer>().material.mainTexture = webCamTexture;
        webCamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotFix = new Quaternion(Input.gyro.attitude.x,
                                            Input.gyro.attitude.y,
                                            -Input.gyro.attitude.y,
                                            -Input.gyro.attitude.w);
        this.transform.localRotation = rotFix;
    }
}
