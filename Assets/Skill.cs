using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Skill : MonoBehaviour {

	public float ColdTime = 2;
	private Image filledImage;
	private float timer = 0;
	private bool isStarted =false;
	public KeyCode key;


	// Use this for initialization
	void Start () {
		filledImage = transform.Find ("FilledImage").GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (key)) {
			isStarted = true;
			timer = 0;
		}

		if (isStarted == false) {
			return;
		}
		timer += Time.deltaTime;

		if (timer >= ColdTime) {
			filledImage.fillAmount = 0;
			isStarted = false;
		} else {
			float x = (ColdTime - timer) / ColdTime;
			filledImage.fillAmount = x;
		}
	}

	public void OnClick() {
		isStarted = true;
		timer = 0;
	}
}
