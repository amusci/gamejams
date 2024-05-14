using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {

        SceneManager.LoadSceneAsync("SampleScene");

    }

    public void goToSettings()
    {

        SceneManager.LoadSceneAsync("Settings");

    }

    public void quitGame()
    {

        Application.Quit();

    }
}
