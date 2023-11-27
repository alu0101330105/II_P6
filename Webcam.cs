using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Webcam : MonoBehaviour
{
    private Material tvMaterial;

    private WebCamTexture webCamTexture;

    [SerializeField]
    private string path = "PATH";

    int captureCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        webCamTexture = new WebCamTexture();
        WebCamDevice[] devices = WebCamTexture.devices;
        for (int i = 0; i < devices.Length; i++)
            Debug.Log(devices[i].name);
        tvMaterial = GetComponent<Renderer>().material;
        
    }

    // Update is called once per frame
    void Update()
    {
        // changed the keybind to "e" to avoid conflict with the "s" keybind in SimpleMovement.cs
        if (Input.GetKey("e")) {
            tvMaterial.mainTexture = webCamTexture; 
            webCamTexture.Play(); 
        }
        if (Input.GetKey("p")) { webCamTexture.Pause(); }
        if (Input.GetKeyDown("x")) { 
            Texture2D snapshot = new Texture2D(webCamTexture.width, webCamTexture.height);
            snapshot.SetPixels(webCamTexture.GetPixels());
            snapshot.Apply();
            System.IO.File.WriteAllBytes(path + captureCounter.ToString() + ".png", snapshot.EncodeToPNG());
            captureCounter++;
         }
    }
}
