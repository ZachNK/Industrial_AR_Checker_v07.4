using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

public class RenderCamera : MonoBehaviour
{
    public Camera cam;
    private int resWidth;
    private int resHeight;
    //private string path;

    // Use this for initialization
    private void Start()
    {
        resWidth = Screen.width;
        resHeight = Screen.height;
        //path = Application.dataPath + "/RenderCamera/";
        //Debug.Log(path);
    }

    // Update is called once per frame
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    CaptureScreenShot();
        //}
    }

    public void CaptureScreenShot()
    {
        //DirectoryInfo dir = new DirectoryInfo(path);
        //if (!dir.Exists)
        //{
        //    Directory.CreateDirectory(path);
        //}
        //string name;
        //name = path + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".jpg";
        RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
        cam.targetTexture = rt;
        Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
        Rect rec = new Rect(0, 0, resWidth, resHeight);
        cam.Render();
        RenderTexture.active = rt;
        screenShot.ReadPixels(rec, 0, 0);
        screenShot.Apply();

        //byte[] bytes = screenShot.EncodeToJPG();
        //File.WriteAllBytes(name, bytes);
    }
}