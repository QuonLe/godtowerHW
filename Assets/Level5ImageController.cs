using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


	
	public class Level5ImageController : EventTrigger {
	Vector3 distance;
	//void Start (){
		//transform.localPosition = new Vector3 (
			//Random.Range (-555 / 2, 555 / 2),
			//Random.Range (-588 / 2, 588 / 2),	
			//0);
	//}	

	public override void OnBeginDrag(PointerEventData AxisEventData) {
		Vector3 screenMousePos = Input.mousePosition;

		Vector3 worldMousePos = 
			Camera.main.ScreenToWorldPoint (screenMousePos);

		Vector3 canvasMousepos = 
			transform.parent.InverseTransformPoint (worldMousePos);
	
		distance = canvasMousepos - transform.localPosition;
	}
public override void OnDrag(PointerEventData evData){
	
		Vector3 screenMousePos = Input.mousePosition;

		Vector3 worldMousePos = 
			Camera.main.ScreenToWorldPoint (screenMousePos);

		Vector3 canvasMousepos = 
			transform.parent.InverseTransformPoint (worldMousePos);

		Vector3 expectedImagePos = canvasMousepos - distance;
		transform.localPosition = new Vector3(
			Mathf.Clamp (expectedImagePos.x, -233, 230),
			Mathf.Clamp (expectedImagePos.y, -167, 193),
			transform.localPosition.z
		);

	}
}