using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilitiesTwo : MonoBehaviour {

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision) {
		//Assigns the collision to a GameObject variable
		GameObject other = collision.gameObject;

		//A switch statement checking for different tags that the collisions might have.
		switch (other.tag) {
		case "Player":
			//Not sure what I would want to put here, unless I wanted to have the enemy
			//damage the player on contact.
			break;
		case "Laser":
			//Destroys the enemy gameObject. Lowering health can also be used here.
			Destroy (this.gameObject);
			break;
		}
	}

}
