using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Togx : MonoBehaviour {

	public GameObject IsOn;
	public GameObject IsOff;

	private Toggle toggle;

	// Use this for initialization
	void Start () {
		toggle = GetComponent<Toggle> ();
		OnValueChange (toggle.isOn);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnValueChange(bool x) {
		IsOn.SetActive (x);
		IsOff.SetActive (!x);
	}
}
