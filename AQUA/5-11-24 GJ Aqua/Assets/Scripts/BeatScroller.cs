using UnityEngine;

public class BeatScroller : MonoBehaviour
{

    public float beatTempo; // tempo variable

    public bool hasStarted; // start bool

    void Start()
    /* Start is called before the first frame */
    {

        beatTempo = beatTempo / 60f; // how fast to move per second

    }


    void Update()
    /* Update is called each frame */
    {

        if (!hasStarted) // if we havent started
        {

            /*if (Input.anyKeyDown) // any key down will allow us to start
            {

                hasStarted = true;

            }*/

        }
        else // when started
        {

            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f); // have our notes fall same tempo as our beat

        }

    }
}
