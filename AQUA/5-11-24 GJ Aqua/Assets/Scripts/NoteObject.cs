using Unity.VisualScripting;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canBePressed; // bool to see if key can be pressed

    public KeyCode keyToPress; // which key to press

    void Start()
    /* Start called before first frame */
    {

    }

    void Update()
    /* Called every frame */
    {
        if (PauseMenu.isPaused == false)
        {

            if (Input.GetKeyDown(keyToPress)) // if key pressed
            {

                if (canBePressed == true) // if it can be pressed
                {

                    gameObject.SetActive(false); // remove gameobject
                    GameManager.instance.noteHit();

                }


            }

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    /* When note hits a button, allow it to be pressed */
    {

        if (other.tag == "Activator")
        {

            canBePressed = true;

        }

    }

    private void OnTriggerExit2D(Collider2D other)
    /* If not passes button or not colliding with button, cannot be pressed */
    {

        if (other.tag == "Activator")
        {

            canBePressed = false;

            GameManager.instance.noteMiss();

        }

    }
}
