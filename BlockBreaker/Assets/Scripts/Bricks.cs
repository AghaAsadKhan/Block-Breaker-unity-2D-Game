using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {

	public int maxHits;

	private int timesHits;

	public static int breakableCount = 0;

	private LevelManager levelManager;
	private bool isBreakable;

	// Use this for initialization

	void Start () 

	{
		isBreakable	= (this.tag == "breakable");
		// keep track of breakable bricks

		if (isBreakable)
		{
			breakableCount++ ;

		}
		timesHits = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col){
		
		if(isBreakable)
		{
			HandleHits ();
		}
	}

	void HandleHits (){
		timesHits++;
		if(timesHits >= maxHits){
			breakableCount -- ;
			levelManager.BrickDestoyed ();
			Destroy (gameObject);
		}

	}
	void SimulateWin ()
	{
		levelManager.LoadNextLevel ();
	}
}
 