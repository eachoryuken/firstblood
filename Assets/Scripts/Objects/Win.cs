using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {
	
	void Start () {
		float x=Random.Range(-2f, 3.5f);
		float z=Random.Range(-2f, 3.5f);
		transform.position=new Vector3(x,transform.position.y,z);
	}

	
	void OnCollisionEnter(Collision collision){
		if(collision.collider.gameObject.name=="Char"){
			GlobalVars.score+=1;
		}
		
		if (GlobalVars.score==5){
			GlobalVars.score=0;
			Application.LoadLevel(2);
		}
		Destroy(gameObject);
	}	
}
