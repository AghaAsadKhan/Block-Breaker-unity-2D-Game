using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
	public void LoadNextLevel(){
		// load next level using its index number
		Application.LoadLevel (Application.loadedLevel + 1);
	}

	public void BrickDestoyed(){

		// using static count veriable to load next level
		if (Bricks.breakableCount <= 0) 
		{
			LoadNextLevel();       
		}
	}

}
