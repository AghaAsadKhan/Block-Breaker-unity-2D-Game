using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;


	// Use this for initialization
	void Start () 
	   
	{    // avoid to creating new music object
		if (instance != null) 
		{   
			Destroy (gameObject);
			print ("Copied Music");
		
		} else 
		
		{   //  do not destroy music object make the music entire game
			instance = this; // class level instance
			GameObject.DontDestroyOnLoad (gameObject);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
