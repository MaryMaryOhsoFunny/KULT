using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonHandler : MonoBehaviour
{

    public void OnStartButtonClicked()
    {
        
        Debug.Log("Start button clicked!");
        //Charge la prochaine scène ou commence le jeu
        SceneManager.LoadScene("OpeningAnimation(tree)"); 

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
