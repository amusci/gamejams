using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{


    public void backToMainMenu()
    {

        SceneManager.LoadSceneAsync("Main Menu");

    }
    public void Twinkle()
    {

        SceneManager.LoadSceneAsync("Twinkle");

    }

    public void BabyShark()
    {

        SceneManager.LoadSceneAsync("Lullaby");

    }

}
