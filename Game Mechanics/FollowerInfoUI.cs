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
        nameText.text = "Name: " + follower.Name;
        loyaltyText.text = "Loyalty: " + follower.Loyalty;
        influenceText.text = "Influence: " + follower.Influence;
        charismaText.text = "Charisma: " + follower.Charisma;
        obedienceText.text = "Obedience: " + follower.Obedience;
        roleText.text = "Role: " + follower.Role;
    }
}
