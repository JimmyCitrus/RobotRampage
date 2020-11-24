using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    private static Game singleton;
    [SerializeField]
    RobotSpawn[] spawns;

    public int enemiesLeft;

    // Spawn some robots once the game starts
    void Start ()
    {
        singleton = this;
        SpawnRobots();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // Method to spawn the robots at their teleporters
    private void SpawnRobots()
    {
        foreach (RobotSpawn spawn in spawns)
        {
            spawn.SpawnRobot();
            enemiesLeft++;
        }
    }
}
