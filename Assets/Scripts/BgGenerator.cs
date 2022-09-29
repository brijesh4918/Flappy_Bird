using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgGenerator : MonoBehaviour {
	public GameObject background;
	public Transform GenPoint;
	float width;
	// Use this for initialization
	void Start () {
		width = background.GetComponent<BoxCollider2D>().size.x;
		//print(width);
	}
	
	// Update is called once per frame
	void Update () {
		
		if(transform.position.x < GenPoint.position.x){
			transform.position = new Vector3(transform.position.x+width,transform.position.y,transform.position.z);
			Vector3 newPos = new Vector3(transform.position.x,transform.position.y,transform.position.z);
			Instantiate(background,newPos,Quaternion.identity);

		}
	}
}
