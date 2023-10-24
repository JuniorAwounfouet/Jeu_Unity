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
        StartCoroutine(PlayGameCoroutine());
    }

    private IEnumerator PlayGameCoroutine()
    {
        AudioManager.instance.PlayMusic(SoundName.EndIntro, false);

        while (AudioManager.instance.musicSrc.isPlaying)
            yield return null;

        SceneManager.LoadScene(SceneName.Test);
    }

    public void QuitGame()
    {
        Debug.Log("Game quit");
        Application.Quit(); // Can't be able to test in the editor
    }
}
