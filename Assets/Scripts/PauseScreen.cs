using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResumeGame()
    {
        GameManager.instance.PauseUnPause();
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene(SceneNames.MainMenu);
    }

    public void QuitGame()
    {
        Debug.Log("Game quit");
        Application.Quit();
    }
}
