﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    public int type;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //If the player collides with a pickup, give them the pickup's ability
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<Player>() != null
        && collider.gameObject.tag == "Player")
        {
            collider.gameObject.GetComponent<Player>().PickUpItem(type);
            GetComponentInParent<PickupSpawn>().PickupWasPickedUp();
            Destroy(gameObject);
        }
    }
}