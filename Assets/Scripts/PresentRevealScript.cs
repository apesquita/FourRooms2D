using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresentRevealScript : MonoBehaviour
{
    public GameObject present;
    public int presentIndex;

    void Start()
    {
        if (GameController.control.experimentVersion == "micro2D_debug_portal")
        {
            // In debug mode, get the current trial's reward position based on the current scene index
            int currentTrialIndex = GameController.control.GetCurrentMapIndex();

            // Ensure we're using the correct reward position for this trial
            Vector3 rewardPosition = GameController.control.rewardSpawnLocations[0];

            // Place this object at the reward location
            transform.position = rewardPosition;
        }
        else
        {
            // Normal mode - use configured spawn locations
            transform.position = GameController.control.presentPositions[presentIndex];
        }
    }
}