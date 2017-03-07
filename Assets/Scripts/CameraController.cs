using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	private Transform cameraTransform;

	// Use this for initialization
	void Start () {
		cameraTransform = this.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		cameraTransform.eulerAngles = new Vector3 (0, 0, 0);
	}
}
