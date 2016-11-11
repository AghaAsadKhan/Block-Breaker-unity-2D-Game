using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Paddel paddle;
	private bool hasStarted = false;

	private Vector3 paddleToBallVector;
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddel> ();
		// make ball posision on the paddle when game start
		paddleToBallVector = this.transform.position - paddle.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {

			if(!hasStarted){
			// make movement of the ball with the paddle if the mouse not clicked 
			this.transform.position = paddle.transform.position + paddleToBallVector;

			// lanch the ball if the button is clicked 
			if (Input.GetMouseButtonDown(0))// 
			{
				print ("Mouse clicked, lanch ball");
				hasStarted = true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 10f);
			}
		
		}
	}
	}