using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCam : MonoBehaviour
{
    // Start is called before the first frame update
    WebCamTexture webcamTexture;
    void Start()
    {
        
        // Debug.Log(webcamTexture.deviceName);
        WebCamDevice[] devices = WebCamTexture.devices;
        WebCamTexture webcamTexture;
        Renderer renderer = GetComponent<Renderer>();
        for (int i =0; i<devices.Length; i++)
        {
            Debug.Log(devices[i].name);
            if (devices[i].name.Contains("OBS"))
            {
                webcamTexture = new WebCamTexture(devices[i].name);
                renderer.material.mainTexture = webcamTexture;
                webcamTexture.Play();
                Debug.Log("play");
                break;
            }
        }
      
        
        
        
    }
}
