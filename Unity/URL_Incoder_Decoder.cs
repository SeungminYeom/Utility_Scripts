using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL_Incoder_Decoder : MonoBehaviour
{
    // 한글 -> %ed%85%94%eb%a7%81
    public string URL_Incoding(string url)
    {
        return UnityEngine.Networking.UnityWebRequest.EscapeURL(url);
    }
    
    // %ed%85%94%eb%a7%81 -> 한글
    public string URL_Decoding(string url)
    {
        return UnityEngine.Networking.UnityWebRequest.UnEscapeURL(url);
    }
}
