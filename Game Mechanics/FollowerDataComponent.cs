using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerDataComponent : MonoBehaviour
{
    public string followerName;
    public int loyalty;
    public int influence;
    public int charisma;
    public int obedience;
    public string role;

    public Follower ToFollower()
    {
        return new Follower(followerName, loyalty, influence, charisma, obedience, role);
    }
}
