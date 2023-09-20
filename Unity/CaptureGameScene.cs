using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capture : MonoBehaviour
{
    public string savePath
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F12))
        {
            StartCoroutine(Rendering());
        }
    }

    IEnumerator Rendering()
    {
        yield return new WaitForEndOfFrame();

        byte[] imgBytes;
        string path = @$"{savePath}\Capture_{DateTime.Now.ToString("yyyymmdd hhmmss")}.png";

        Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, false);
        texture.Apply();

        imgBytes = texture.EncodeToPNG();
        System.IO.File.WriteAllBytes(path, imgBytes);
    }
}
