
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipegenerator : MonoBehaviour {
	public GameObject pipes; 
	public GameObject background;
	public Transform GenPoint;
	float width;
	// Use this for initialization
	void Start () {
		width = background.GetComponent<BoxCollider2D>().size.x;
//		print(width);
	}
	
	// Update is called once per frame
	void Update () {
		
		if(transform.position.x < GenPoint.position.x){
			float ren= Random.Range(-4,3);
			transform.position = new Vector3(transform.position.x+width,transform.position.y,transform.position.z);
			Vector3 newPos = new Vector3(transform.position.x,ren,transform.position.z);
			Instantiate(pipes,newPos,Quaternion.identity);
			
			


		}
	}
}
