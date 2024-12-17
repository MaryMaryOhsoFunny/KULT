using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextFadeEffect : MonoBehaviour
{
    public CanvasGroup textCanvasGroup;
    public Button startButton;
    public float fadeDuration = 2f;
    private bool isFading = false;
    private float fadeTimer = 0f;

    void Start()
    {
        startButton.gameObject.SetActive(false);
        textCanvasGroup.alpha = 1f; // Ensure text is fully visible at start

        // startButton.onClick.AddListener(OnStartButtonClicked);
    }

    void Update()
    {
        if (!isFading)
        {
            fadeTimer += Time.deltaTime;
            if (fadeTimer >= fadeDuration)
            {
                isFading = true;
                fadeTimer = 0f;
            }
        }
        else
        {
            textCanvasGroup.alpha = Mathf.Lerp(1f, 0f, fadeTimer / fadeDuration);
            fadeTimer += Time.deltaTime;

            if (fadeTimer >= fadeDuration)
            {
                textCanvasGroup.alpha = 0f;
                startButton.gameObject.SetActive(true);
                enabled = false;
            }
        }
    }

    //Methode pour le bouton start
    // void OnStartButtonClicked()
    // {
    //     SceneManager.LoadScene("GameScene"); //Remplacer "GameScene" avec nom de la scene.
    // }
}