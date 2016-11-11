using UnityEngine;
using System.Collections;

public class LooseCollider : MonoBehaviour {

	private LevelManager levelManager; // instance of Level manager class

	void OnTriggerEnter2D (Collider2D trigger){

		levelManager = GameObject.FindObjectOfType<LevelManager> (); 

		// jump to play again screen
		levelManager.LoadLevel("Losse Screen");

	}

	void OnCollisionEnter2D (Collision2D collision){

		print ("Collision");
	}
}
