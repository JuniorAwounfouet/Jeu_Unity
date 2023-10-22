using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneNames.Test);
    }

    public void QuitGame()
    {
        Debug.Log("Game quit");
        Application.Quit(); // Can't be able to test in the editor
    }
}
