using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float Speed = 90;

	// Use this for initialization
	void Start () {
	
	}


	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * Speed);
	}

	public void ChangeSpeed(float NewSpeed) {
		Speed = 360* NewSpeed;
	}
}
