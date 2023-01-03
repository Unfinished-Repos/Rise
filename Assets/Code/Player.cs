using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour {
	float[] Mouse_Position_Old;
	float[] Mouse_Position_New;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Mouse_Position_New[1] = Input.mousePosition.x;
		Mouse_Position_New[2] = Input.mousePosition.y;
		if (Input.GetMouseButton(0)) {

		}
		Mouse_Position_Old[1] = Input.mousePosition.x;
		Mouse_Position_Old[2] = Input.mousePosition.y;
	}
}
