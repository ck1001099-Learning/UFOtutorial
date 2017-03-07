using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

	public float forcevalue;
	public ScoreManager scoreManager;

	private Rigidbody2D UFOrb;

	// Use this for initialization
	void Start () {
		UFOrb = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			UFOrb.AddForce (new Vector2 (0, forcevalue));
		}
		if (Input.GetKey (KeyCode.A)) {
			UFOrb.AddForce (new Vector2 (-forcevalue, 0));
		}
		if (Input.GetKey (KeyCode.S)) {
			UFOrb.AddForce (new Vector2 (0, -forcevalue));
		}
		if (Input.GetKey (KeyCode.D)) {
			UFOrb.AddForce (new Vector2 (forcevalue, 0));
		}

	}

	void OnTriggerEnter2D(Collider2D other){
		other.gameObject.SetActive (false);
		scoreManager.AddScore (100);
	}
}
