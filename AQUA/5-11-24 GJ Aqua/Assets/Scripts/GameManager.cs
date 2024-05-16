using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public AudioSource music; // allows us to input music

    public bool startPlaying; // check to see we have started playing

    public BeatScroller bs; // allows us to access beat scroller script


    public static GameManager instance; // only 1 instance of the game manager

    public int currentScore; // current score

    public int scorePerNote = 300; // score per note
    public int deductScore = 100;

    public int currentWaterLevel;
    public int waterLevelPerNote = 11;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        currentWaterLevel = 0; // Initialize water level
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
        if (currentWaterLevel >= 100)
        {

            currentWaterLevel = 100;

        }
        else
        {

            currentWaterLevel += waterLevelPerNote * 2;

        }
        Debug.Log(currentWaterLevel + "hit");
    }

    public void noteMiss()
    /* this function will be called when a note is missed */
    {

        currentScore -= deductScore;
        scoreText.text = "Score: " + currentScore;
        if (currentWaterLevel <= 10)
        {

            currentWaterLevel = 10;

        }
        else
        {

            currentWaterLevel -= waterLevelPerNote;

        }
        Debug.Log(currentWaterLevel + "miss");

    }




}




