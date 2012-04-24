using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	void Start () {
		//this.enabled=false;
	}
	
	void Update () {		
		float x=transform.position.x;
		float z=transform.position.z;
		if(x<GlobalVars.herox){x+=GlobalVars.velop;}
		if(x>GlobalVars.herox){x-=GlobalVars.velop;}
		if(z<GlobalVars.heroz){z+=GlobalVars.velop;}
		if(z>GlobalVars.heroz){z-=GlobalVars.velop;}
		transform.position= new Vector3(x,transform.position.y,z);
		
	}
	
	void OnCollisionEnter(Collision collision){
		if(collision.collider.gameObject.name=="Char"){
			//GlobalVars.score=0;
			Application.LoadLevel(Application.loadedLevel);
	
		}
	}

}
