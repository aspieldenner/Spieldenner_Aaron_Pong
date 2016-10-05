using UnityEngine;
using System.Collections;

public class PaddleRight : MonoBehaviour {

	public float paddleSpeed = .7f;


	private Vector3 playerPos = new Vector3 (7.92f, -7.92f, 0);

	void Update () 
	{
		float yPos = transform.position.y + (Input.GetAxis("Vertical") * paddleSpeed); //allows the player to control the paddle with the L and R arrow keys
		playerPos = new Vector3 (7.92f, Mathf.Clamp (yPos, -4f, 4f), 0f); //limits how far the paddle can slide
		transform.position = playerPos;

	}
}
