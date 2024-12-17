using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextMeltingEffect : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public Button startButton;
    public float meltDelay = 10f;
    public float meltSpeed = 0.1f;
    public float meltRandomness = 0.05f; // Random melting speed

    private bool isMelting = false;
    private float meltTimer = 0f;
    
    void Start()
    {
        startButton.gameObject.SetActive(false);
    }
    void Update()
    {
        meltTimer += Time.deltaTime;
        Debug.Log("Melt Timer: " + meltTimer);

        if (meltTimer >= meltDelay && !isMelting)
        {
            isMelting = true;
            Debug.Log("Melting started");
        }

        if (isMelting)
        {
            bool allMelted = true;

            textMesh.ForceMeshUpdate(); // S'assure que le mesh data est à jour

            // Simple melting effect by moving characters down
            for (int i = 0; i < textMesh.textInfo.characterCount; i++)
            {
                var charInfo = textMesh.textInfo.characterInfo[i];
                if (charInfo.isVisible)
                {
                    Vector3 offset = new Vector3(0, -(meltSpeed + Random.Range(-meltRandomness, meltRandomness)) * Time.deltaTime, 0);
                    textMesh.textInfo.characterInfo[i].bottomLeft += offset;
                    textMesh.textInfo.characterInfo[i].bottomRight += offset;
                    textMesh.textInfo.characterInfo[i].topLeft += offset;
                    textMesh.textInfo.characterInfo[i].topRight += offset;

                    //Check si le character est tjs visible à l'écran
                    if (textMesh.textInfo.characterInfo[i].bottomLeft.y > -Screen.height)
                    {
                        allMelted = false;
                    }
                }
            }
            
            textMesh.UpdateVertexData(TMP_VertexDataUpdateFlags.All);

            //Si tous les characters ont fondus hors de l'écran, montrer le bouton start
            if (allMelted)
            {
                isMelting = false;
                startButton.gameObject.SetActive(true);
            }

        }
    }
}
