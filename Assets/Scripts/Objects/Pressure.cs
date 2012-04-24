using UnityEngine;
using System.Collections;

public class Pressure : MonoBehaviour {
	
	void OnCollisionEnter(Collision collision){
		if(collision.collider.gameObject.name=="Cube"){
			Application.LoadLevel(0);
		}
		if(collision.collider.gameObject.name=="Char"){
			Application.LoadLevel(2);
		}
	}	
	
}
