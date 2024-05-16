using UnityEngine;

public class WaterMeterManager : MonoBehaviour
{
    public Animator waterAnimator; // Reference to the Animator component

    void Update()
    {
        // Update the water level animation based on the current water level from the GameManager
        int currentWaterLevel = GameManager.instance.currentWaterLevel;
        waterAnimator.SetInteger("WaterLevel", currentWaterLevel);
    }
}
