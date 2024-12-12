using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RecruitSystem : MonoBehaviour
{
    public List<Follower> followers = new List<Follower>();
    public TextMeshProUGUI followerCountText;
    public GameObject followerDetailPanel; //Panel pour les détails des followers
    public Button recruitButton, letGoButton;

    private NameGenerator nameGenerator;
    private FollowerInfoUI followerInfoUI;
    private GameObject selectedFollower;

    void Start()
    {
        // Trouve le NameGenerator component dans la scene
        nameGenerator = FindObjectOfType<NameGenerator>();
        followerInfoUI = followerDetailPanel.GetComponent<FollowerInfoUI>();
        UpdateFollowerCount();
        followerDetailPanel.SetActive(false); //Cache le panel au départ
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, Mathf.Infinity, LayerMask.GetMask("PotentialFollower"));

            if (hit.collider != null)
            {
                SelectFollower(hit.collider.gameObject);
            }
        }
    }

    void SelectFollower(GameObject potentialFollower)
    {
        selectedFollower = potentialFollower;
        Follower followerData = GetFollowerData(potentialFollower);
        followerInfoUI.UpdateFollowerInfo(followerData);
        SetupButtonListeners(followerData);
        followerDetailPanel.SetActive(true);
    }

    void SetupButtonListeners(Follower followerData)
    {
        recruitButton.onClick.RemoveAllListeners();
        recruitButton.onClick.AddListener(() => RecruitFollower(selectedFollower));

        letGoButton.onClick.RemoveAllListeners();
        letGoButton.onClick.AddListener(LetGoFollower);
    }


    void RecruitFollower(GameObject potentialFollower)
    {
        if (potentialFollower == null)
        {
            Debug.LogError("PotentialFollower is null");
            return;
        }
        Follower followerData = GetFollowerData(potentialFollower);
        if(followerData == null)
        {
            Debug.LogError("Follower data is null");
            return;
        }

        followers.Add(followerData);
        Destroy(potentialFollower);
        UpdateFollowerCount();
        followerDetailPanel.SetActive(false);
    }

    void LetGoFollower()
    {
        followerDetailPanel.SetActive(false); // Hide the detail panel
    }

    void UpdateFollowerCount()
    {
        followerCountText.text = "Followers: " + followers.Count;
    }


    Follower GetFollowerData(GameObject potentialFollower)
    {
        FollowerDataComponent dataComponent = potentialFollower.GetComponent<FollowerDataComponent>();
        if(dataComponent != null)
        {
            return dataComponent.ToFollower();
        }
        else
        {
            Debug.LogError("FollowerDataComponent not found on potentialFollower");
            return null;
        }
    }
}
