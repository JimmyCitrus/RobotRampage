using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawn : MonoBehaviour {
    [SerializeField]
    private GameObject[] pickups;
	
	// Update is called once per frame
	void Update () {
		
	}

    // Determines the time and positions of a pickup
    void spawnPickup()
    {
        // Instantiate a random pickup
        GameObject pickup = Instantiate(pickups[Random.Range(0,
       pickups.Length)]);
        pickup.transform.position = transform.position;
        pickup.transform.parent = transform;
    }

    // If it's been 20 seconds since a pickup spawned, spawn a new one
    IEnumerator respawnPickup()
    {
        yield return new WaitForSeconds(20);
        spawnPickup();
    }
    // Spawns a pickup once the game starts
    void Start()
    {
        spawnPickup();
    }
    // Starts the coroutine to respawn when a pickup was picked up
    public void PickupWasPickedUp()
    {
        StartCoroutine("respawnPickup");
    }
}
