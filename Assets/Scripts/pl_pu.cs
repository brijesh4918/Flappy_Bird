using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pl_pu : MonoBehaviour {
int pl=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	 public void play_pause()
	 {
		 pl=1-pl;
		 if(pl==1)
		 {
			// pl=0;
			 Time.timeScale=0;
		 }


		  if(pl==0)
		 {
			// pl=1;
			 Time.timeScale=1;
		 }

	 }
	 public void back1()
	 {
		 SceneManager.LoadScene("home");	
	 }
}
