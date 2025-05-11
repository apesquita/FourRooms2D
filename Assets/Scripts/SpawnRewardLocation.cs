using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnRewardLocation : MonoBehaviour {

    /// <summary>
    /// Choose a location to spawn the reward from that is actually on the grid (not in the holes).
    /// Author: Hannah Sheahan, sheahan.hannah@gmail.com
    /// Date: Dec 2018
    /// </summary>

    public int rewardIndex=0;


    void Start()
    {
        if (GameController.control.experimentVersion == "nav2D_teleporter")
        {
            // Set fixed spawn position for debug version
            transform.position = GameController.control.rewardSpawnLocations[rewardIndex];
            Debug.Log($"Debug portal mode: Spawning reward at fixed position  {transform.position}");
        }
        else
        {
            // Use original dynamic spawn system for all other versions
            transform.position = GameController.control.rewardSpawnLocations[rewardIndex];
            Debug.Log($"Normal mode: Spawning reward at dynamic position {transform.position}");
        }
    }
}