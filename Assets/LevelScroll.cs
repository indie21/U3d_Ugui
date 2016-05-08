using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelScroll : MonoBehaviour, IBeginDragHandler, IEndDragHandler {

	private ScrollRect scrollRect;
	private float[] pageArray = new float[] { 0, 0.3333f, 0.6666f,  1 };
	private float targetHorizontalPosition;
	public float smoothing =3;
	private bool is_dragging =false;
	public Toggle[] toggleArray;

	// Use this for initialization
	void Start () {
		scrollRect = GetComponent<ScrollRect> ();
	}

	// Update is called once per frame
	void Update () {
		if (is_dragging == false) {
			scrollRect.horizontalNormalizedPosition = Mathf.Lerp (scrollRect.horizontalNormalizedPosition,
				targetHorizontalPosition,
				Time.deltaTime * smoothing
			);
		}
	}

	public void OnBeginDrag(PointerEventData eventData) {	
		is_dragging = true;	
	}
		
	public void OnEndDrag(PointerEventData eventData) {				
		float temp = scrollRect.horizontalNormalizedPosition;
		int index = 0;
		float offset = Mathf.Abs (pageArray [index] - temp);

		for (int i = 1; i < pageArray.Length; i++) {
			float offsetTemp = Mathf.Abs (pageArray [i] - temp);
			if (offsetTemp < offset) {
				index = i;
				offset = offsetTemp;
			}
		}

		print (pageArray [index]);
		targetHorizontalPosition = pageArray[index];
		is_dragging = false;
		toggleArray [index].isOn = true;
	}

	public void OnToggleValueChange1(bool isOn){
		print (isOn+"1");
		if (isOn) {
			targetHorizontalPosition = pageArray [0];
		}
	}

	public void OnToggleValueChange2(bool isOn){
		print (isOn+"2");
		if (isOn) {
			targetHorizontalPosition = pageArray [1];
		}
	}
	

	public void OnToggleValueChange3(bool isOn){
		print (isOn+"3");
		if (isOn) {
			targetHorizontalPosition  = pageArray [2];
		}

	}

	public void OnToggleValueChange4(bool isOn){
		print (isOn+"4");
		if (isOn) {
			targetHorizontalPosition  = pageArray [3];
		}

	}

}
