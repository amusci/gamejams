using UnityEngine;

public class ButtonController : MonoBehaviour
{

    private SpriteRenderer spriteRenderer; // allow us to use the sprite renderer
    public Sprite defaultImage; // set default sprite
    public Sprite pressedImage; // set sprite after pressed key

    public KeyCode keyToPress; // allow us to choose which key in inspector

    public AudioClip hitSound; // allow us to choose which sound to play when hit

    void Start()
    /* Called before first frame */
    {

        spriteRenderer = GetComponent<SpriteRenderer>(); // get sprite renderer

    }


    void Update()
    /* Called once per frame */
    {
        if (!PauseMenu.isPaused)
        {

            if (Input.GetKeyDown(keyToPress)) // if the key is pressed 
            {

                spriteRenderer.sprite = pressedImage; // change the sprite to pressed sprite
                PlayHitSound();

            }
            if (Input.GetKeyUp(keyToPress)) // when key is released
            {

                spriteRenderer.sprite = defaultImage; // revert back to default sprite

            }


        }



    }

    private void PlayHitSound()
    {
        if (hitSound != null)
        {
            // Play the assigned hit sound
            AudioSource.PlayClipAtPoint(hitSound, transform.position);
        }
    }
}
