using UnityEngine;
using System.Collections;

public class LP : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 Rot = Vector3(0.5f, 0.0f, 0.0f);
	iTween.RotateBy(this, Rot, 1);
	}
}
