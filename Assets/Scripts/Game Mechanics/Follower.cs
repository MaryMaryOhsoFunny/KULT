using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower
{
    public string Name { get; set; }
    public int Loyalty { get; set; }
    public int Influence { get; set; }
    public int Charisma { get; set; }
    public int Obedience { get; set; }
    public string Role { get; set; }

    public Follower(string name, int loyalty, int influence, int charisma, int obedience, string role)
    {
        Name = name;
        Loyalty = loyalty;
        Influence = influence;
        Charisma = charisma;
        Obedience = obedience;
        Role = role;
    }
}