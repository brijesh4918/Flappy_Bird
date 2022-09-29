using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour {
	Rigidbody2D rb;
	int cnt=0;
	public Text t,tc;
	int pl=1;
	int coin=0;
	public float speed,jumpSpeed;
	// Use this for initialization
	void Start () {
			Time.timeScale=1;
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2(speed,rb.velocity.y);
		if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)){
			rb.velocity = new Vector2(rb.velocity.x,jumpSpeed);
		}
	}
	 
	 private void OnTriggerEnter2D(Collider2D other) {
		 if(other.gameObject.tag=="pipes")
		{
			Debug.Log("touch");
		
			cnt=0;
			coin = 0;
		//	SceneManager.LoadScene("lose");
		GameObject.Find("lose").transform.GetChild(0).gameObject.SetActive(true);

			
			
		}
		 if(other.gameObject.tag=="pass")
		{
		
			cnt++;	
				Debug.Log(cnt);
			
			t.text = ("POINT : " + cnt);
		}
		 if(other.gameObject.tag=="coin")
		{
		
		//	cnt++;	
		//		Debug.Log(cnt);
			
			//t.text = ("POINT : " + cnt);
			coin++;
			tc.text = "COIN : "+coin;
			Destroy(other.gameObject);
		}
		if(cnt==10)
		{
			//SceneManager.LoadScene("win");
			//GameObject.Find("win").transform.GetChild(0).gameObject.SetActive(true);
			GameObject.Find("win").transform.GetChild(0).gameObject.SetActive(true);

		}
	 }
	 public void back()
	 {

	 }
	
}
