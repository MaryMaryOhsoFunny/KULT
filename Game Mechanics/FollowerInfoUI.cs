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
        nameText.text = "Name: " + follower.name;
        loyaltyText.text = "Loyalty: " + follower.loyalty;
        influenceText.text = "Influence: " + follower.influence;
        charismaText.text = "Charisma: " + follower.charisma;
        obedienceText.text = "Obedience: " + follower.obedience;
        roleText.text = "Role: " + follower.role;
    }
}
