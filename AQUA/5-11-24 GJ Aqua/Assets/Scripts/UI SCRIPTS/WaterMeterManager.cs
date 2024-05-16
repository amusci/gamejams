using UnityEngine;

public class WaterMeterManager : MonoBehaviour
{
    public Animator waterAnimator; // Reference to the Animator component

    void Update()
    {
        UpdateWaterLevelAnimation(GameManager.instance.currentWaterLevel);
    }

    void UpdateWaterLevelAnimation(int currentWaterLevel)
    {
        if (currentWaterLevel > 90)
        {
            waterAnimator.Play("waterlevel90to100");
        }
        else if (currentWaterLevel > 80)
        {
            waterAnimator.Play("waterlevel80to90");
        }
        else if (currentWaterLevel > 70)
        {
            waterAnimator.Play("waterlevel70to80");
        }
        else if (currentWaterLevel > 60)
        {
            waterAnimator.Play("waterlevel60to70");
        }
        else if (currentWaterLevel > 50)
        {
            waterAnimator.Play("waterlevel50to60");
        }
        else if (currentWaterLevel > 40)
        {
            waterAnimator.Play("waterlevel40to50");
        }
        else if (currentWaterLevel > 30)
        {
            waterAnimator.Play("waterlevel30to40");
        }
        else if (currentWaterLevel > 20)
        {
            waterAnimator.Play("waterlevel20to30");
        }
        else if (currentWaterLevel > 10)
        {
            waterAnimator.Play("waterlevel10to20");
        }
        else
        {
            waterAnimator.Play("waterlevel0to10");
        }
    }
}
