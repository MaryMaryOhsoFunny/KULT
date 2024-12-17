using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunawaySystem : MonoBehaviour
{
    public List<Follower> followers;
    private List<Follower> runaways = new List<Follower>();

    void Start()
    {
        StartCoroutine(CheckForRunaways());
    }

    private IEnumerator CheckForRunaways()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f); // Check every 10 seconds

            foreach (var follower in new List<Follower>(followers))
            {
                if (follower.ShouldRunAway())
                {
                    followers.Remove(follower);
                    runaways.Add(follower);
                    Debug.Log(follower.Name + " has run away!");
                }
            }
        }
    }

    public void SearchForRunaway(Follower runaway)
    {
        bool found = Random.value > 0.5f; // Example: 50% chance to find the runaway

        if (found)
        {
            Debug.Log("Found " + runaway.Name + "!");
            PresentOptionsForRunaway(runaway);
        }
        else
        {
            Debug.Log(runaway.Name + " could not be found.");
        }
    }

    private void PresentOptionsForRunaway(Follower runaway)
    {
        Debug.Log("Options: Force back, Let go, Kill");
        // Implement UI or logic to handle player's choice
    }

    private void ForceBack(Follower runaway)
    {
        followers.Add(runaway);
        runaways.Remove(runaway);
        Debug.Log(runaway.Name + " has been forced back into the cult.");
    }

    private void LetGo(Follower runaway)
    {
        runaways.Remove(runaway);
        Debug.Log(runaway.Name + " has been let go.");
    }

    private void Kill(Follower runaway)
    {
        runaways.Remove(runaway);
        Debug.Log(runaway.Name + " has been killed.");
    }
}