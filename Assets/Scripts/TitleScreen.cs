using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitToTitleScreenButton()
    {
        SceneManager.LoadScene("Opening Scene", LoadSceneMode.Single);
        print("Clicked ExitToTitleScreenButton");
    }

    public void TutorialButton()
    {
        SceneManager.LoadScene("Tutorial Scene", LoadSceneMode.Single);
        print("Clicked TutorialButton");
    }

    public void StartGameButton()
    {
        SceneManager.LoadScene("World Scene", LoadSceneMode.Single);
        print("Clicked StartGameButton");
    }

    public void ExitButton()
    {
        Application.Quit();
        print("Clicked ExitButton");
    }
}
