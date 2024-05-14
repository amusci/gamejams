using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public AudioSource music; // allows us to input music

    public bool startPlaying; // check to see we have started playing

    public BeatScroller bs; // allows us to access beat scroller script


    public static GameManager instance; // only 1 instance of the game manager

    public int currentScore; // current score

    public int scorePerNote = 100; // score per note

    public Text scoreText;



    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying) // if not playing
        {

            if (Input.anyKeyDown) // any key down will allow us to play + play the music
            {

                startPlaying = true;
                bs.hasStarted = true;

                music.Play(); // music play!!!!!!
            }

        }

    }

    public void noteHit()
    {
        Debug.Log("Hit on time");
        currentScore += scorePerNote;
        scoreText.text = "Score: " + currentScore;
    }

    public void noteMiss()
    /* this function will be called when a note is missed */
    {

        Debug.Log("missed");
        currentScore -= (scorePerNote / 2);
        scoreText.text = "Score: " + currentScore;

    }
}
