
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public AudioSource music;

    public bool startPlaying;

    public BeatScroller bs;


    public static GameManager instance; // only 1 instance of the game manager

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {

            if (Input.anyKeyDown)
            {

                startPlaying = true;
                bs.hasStarted = true;

                music.Play();
            }

        }

    }

    public void noteHit()
    {

        Debug.Log("hit on time");

    }

    public void noteMiss()
    {

        Debug.Log("missed");

    }
}
