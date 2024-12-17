using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower
{
<<<<<<< HEAD
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
=======
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
>>>>>>> 229ed255418afc9902f0c013277e1cbcc380518c
    }
}