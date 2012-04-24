using UnityEngine;
using System.Collections;

public class DerrubaEsfera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision){
		if(collision.collider.gameObject.name=="Esfera"){
			GlobalVars.score+=1;
			//Application.LoadLevel(0);
		}
	}	
}
