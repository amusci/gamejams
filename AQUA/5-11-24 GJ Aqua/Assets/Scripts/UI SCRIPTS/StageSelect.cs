using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public void Twinkle()
    {

        SceneManager.LoadSceneAsync("Twinkle");

    }

    public void BabyShark()
    {

        SceneManager.LoadSceneAsync("Lullaby");

    }

}
