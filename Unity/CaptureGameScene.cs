using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureGameScene : MonoBehaviour
{
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
        string path = @$"C:\Users\YongYongE\Desktop\{DateTime.Now.ToString("yyyymmdd hhmmss")}.png";

        Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, false);
        texture.Apply();

        imgBytes = texture.EncodeToPNG();
        System.IO.File.WriteAllBytes(path, imgBytes);
    }
}
