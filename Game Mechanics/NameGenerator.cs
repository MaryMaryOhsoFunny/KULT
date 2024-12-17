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
<<<<<<< HEAD

    public IEnumerator GenerateRandomFollower(Action<Follower> callback)
    {
        yield return GenerateNameFromAPI((name) =>
        {
            // Generate random attributes
            int loyalty = UnityEngine.Random.Range(0, 101);
            int influence = UnityEngine.Random.Range(0, 101);
            int charisma = UnityEngine.Random.Range(0, 101);
            int obedience = UnityEngine.Random.Range(0, 101);
            string[] roles = { "Leader", "Support", "Scout", "Warrior" };
            string role = roles[UnityEngine.Random.Range(0, roles.Length)];

            // Create a new Follower object
            Follower newFollower = new Follower(name, loyalty, influence, charisma, obedience, role);

            // Return the generated follower
            callback(newFollower);
        });
    }
=======
>>>>>>> 229ed255418afc9902f0c013277e1cbcc380518c
}

