using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {
	public GameObject target;
	Vector3 diff;
	// Use this for initialization
	void Start () {
		diff =  transform.position-target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPos = new Vector3(target.transform.position.x+diff.x,transform.position.y,transform.position.z);	
		transform.position =newPos;
	}
}
