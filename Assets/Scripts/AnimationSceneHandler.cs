using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationSceneHandler : MonoBehaviour
{
    public float animationDuration = 10f; // Duration of the animation in seconds
    private bool isSkipped = false;

    void Start()
    {
        // Start a coroutine to wait for the animation duration
        StartCoroutine(WaitAndLoadGameScene());
    }

    public void SkipAnimation()
    {
        isSkipped = true;
        LoadGameScene();
    }

    private System.Collections.IEnumerator WaitAndLoadGameScene()
    {
        yield return new WaitForSeconds(animationDuration);

        if (!isSkipped)
        {
            LoadGameScene();
        }
    }

    private void LoadGameScene()
    {
        SceneManager.LoadScene("GameBeginning");
    }
}