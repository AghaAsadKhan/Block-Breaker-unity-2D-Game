using UnityEngine;
using System.Collections;

public class Paddel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f); // used to pass 3d positions and directions
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

		// make paddle movment with mouse position & Mathf method is to make paddle within the scene 
		paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f); 
		this.transform.position = paddlePos;
	}
}
