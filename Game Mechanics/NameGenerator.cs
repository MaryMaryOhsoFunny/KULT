using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class NameGenerator : MonoBehaviour
{
    private const string apiUrl = "https://randommer.io/api/Name"; // Replace with actual API URL

    public IEnumerator GenerateNameFromAPI(Action<string> callback)
    {
        using (UnityWebRequest request = UnityWebRequest.Get(apiUrl))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                string generatedName = request.downloadHandler.text;
                callback(generatedName);
            }
            else
            {
                Debug.LogError("Error generating name: " + request.error);
                callback("Default Name");
            }
        }
    }
}

