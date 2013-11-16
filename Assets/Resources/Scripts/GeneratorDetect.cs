using UnityEngine;
using System.Collections;

public class GeneratorDetect : MonoBehaviour {
	
	public float captureProgress = 0;
	public GameObject[] pillars;
	public GameObject[] players;
	public Hashtable playerTable = new Hashtable();
	
	// Use this for initialization
	void Start () {
		this.pillars = GameObject.FindGameObjectsWithTag("Pillar");
		this.players = GameObject.FindGameObjectsWithTag("Player");
		
		foreach (GameObject player in this.players) {
			string myName = player.name;
			this.playerTable[myName] = 0.0f;
			//Debug.Log(myName);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
	
		// check if pillar changes status
		GameObject[] captured = GameObject.FindGameObjectsWithTag("Captured");
		
		switch (captured.Length) {
			case 0: 
				Debug.Log("Lol, nothing");
				break;
			case 1:
				this.captureProgress = this.captureProgress + 0.035f;	
				break;
			case 2: 
				this.captureProgress = this.captureProgress + 0.065f;
				break;
			case 3: 
				this.captureProgress = this.captureProgress + 0.1f;
				break;
		}
		Debug.Log(Mathf.FloorToInt(this.captureProgress));
		
		if(this.captureProgress >= 100) {
			Debug.Log("this game is over");	
		}
		
		foreach (GameObject pillar in this.pillars) {
			//pillar.renderer.material
			
		}
		
		// if pillar gets captured
		// start counting up the players specific counter
		
		//foreach (GameObject player in this.players) {
		
		//}
		
	}
}
