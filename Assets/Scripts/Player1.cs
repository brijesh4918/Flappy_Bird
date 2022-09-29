using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player1 : MonoBehaviour {
	Rigidbody2D rb;

	public float speed,jumpSpeed;
	// Use this for initialization
	void Start () {
			Time.timeScale=1;
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2(speed,rb.velocity.y);
		
	}
	 
	 private void OnTriggerEnter2D(Collider2D other) {
		 if(other.gameObject.tag=="pipes"  ||  other.gameObject.tag=="pass" ||  other.gameObject.tag=="bgg")
		{
				Destroy(other.gameObject);
			
		}
		

	
	 }
}
