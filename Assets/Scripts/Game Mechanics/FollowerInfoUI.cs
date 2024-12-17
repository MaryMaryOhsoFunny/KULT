using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FollowerInfoUI : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI loyaltyText;
    public TextMeshProUGUI influenceText;
    public TextMeshProUGUI charismaText;
    public TextMeshProUGUI obedienceText;
    public TextMeshProUGUI roleText;

    public void UpdateFollowerInfo(Follower follower)
    {
<<<<<<< HEAD
        nameText.text = "Name: " + follower.Name;
        loyaltyText.text = "Loyalty: " + follower.Loyalty;
        influenceText.text = "Influence: " + follower.Influence;
        charismaText.text = "Charisma: " + follower.Charisma;
        obedienceText.text = "Obedience: " + follower.Obedience;
        roleText.text = "Role: " + follower.Role;
=======
        nameText.text = "Name: " + follower.name;
        loyaltyText.text = "Loyalty: " + follower.loyalty;
        influenceText.text = "Influence: " + follower.influence;
        charismaText.text = "Charisma: " + follower.charisma;
        obedienceText.text = "Obedience: " + follower.obedience;
        roleText.text = "Role: " + follower.role;
>>>>>>> 229ed255418afc9902f0c013277e1cbcc380518c
    }
}
