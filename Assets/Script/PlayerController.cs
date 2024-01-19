using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;
	private int score = 0;
	public float speed = 1000f;
	public int health = 5;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
    // Renamed in FixedUpdate
    void FixedUpdate()
    {

		if (Input.GetKey("z"))
		{
			rb.AddForce(0, 0, 500 * Time.deltaTime);
		}

		if (Input.GetKey("s"))
		{
			rb.AddForce(0, 0, -500 * Time.deltaTime);
		}

		if (Input.GetKey("d"))
		{
			rb.AddForce(500 * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey("q"))
		{
			rb.AddForce(-500 * Time.deltaTime, 0, 0);
		}
    }

	// Function that ++ when player get a coin
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Pickup"))
		{
			score++;
			Debug.Log("Score: " + score);
			other.gameObject.SetActive(false);
		}
		else if (other.CompareTag("Trap"))
		{
			health--;
			Debug.Log("Heatlh: " + health);
		}
	}
}