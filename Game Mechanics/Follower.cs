using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower
{
    public string name;
    public int loyalty;
    public int influence;
    public int charisma;
    public int obedience;
    public string role;

    public Follower(string name, int loyalty, int influence, int charisma, int obedience, string role)
    {
        this.name = name;
        this.loyalty = loyalty;
        this.influence = influence;
        this.charisma = charisma;
        this.obedience = obedience;
        this.role = role;
    }
}