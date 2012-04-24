using UnityEngine;
using System.Collections;

public class DerrubaBolinha : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collision){
		if(collision.collider.gameObject.name=="Buraco"){
			Destroy(gameObject);
		}
	}	
}
