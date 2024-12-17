using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonHandler : MonoBehaviour
{

    public void OnStartButtonClicked()
    {
<<<<<<< HEAD
        
        Debug.Log("Start button clicked!");
        //Charge la prochaine scène ou commence le jeu
        SceneManager.LoadScene("OpeningAnimation(tree)"); 

=======
        //Charge la prochaine scène ou commence le jeu
        SceneManager.LoadScene("GameScene"); 
>>>>>>> 229ed255418afc9902f0c013277e1cbcc380518c
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
