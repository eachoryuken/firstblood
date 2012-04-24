using UnityEngine;
using System.Collections;

public class Lulz : MonoBehaviour {

	void Update () {
		float z=transform.position.z;
		float x=transform.position.x;
	
		if((Input.GetKey("w"))||Input.GetKey("up")){z+=0.2f;}
		if((Input.GetKey("s"))||Input.GetKey("down")){z-=0.2f;}
		if((Input.GetKey("a"))||Input.GetKey("left")){x-=0.2f;}
		if((Input.GetKey("d"))||Input.GetKey("right")){x+=0.2f;}
		
		transform.position=new Vector3(x,transform.position.y,z);
		GlobalVars.herox=transform.position.x;
		GlobalVars.heroz=transform.position.z;
	}
}
