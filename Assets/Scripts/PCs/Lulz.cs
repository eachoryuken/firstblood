using UnityEngine;
using System.Collections;

public class Lulz : MonoBehaviour {

	void Update () {
	//dyrtytyrty
		float zpeed = 0.2f;
		float z=transform.position.z;
		float x=transform.position.x;
	
		if((Input.GetKey("w"))||Input.GetKey("up")){z+=zpeed;}
		if((Input.GetKey("s"))||Input.GetKey("down")){z-=zpeed;}
		if((Input.GetKey("a"))||Input.GetKey("left")){x-=0.2f;}
		if((Input.GetKey("d"))||Input.GetKey("right")){x+=0.2f;}
		
		if (Input.touchCount == 1) {
			z+=zpeed;
		}
		if (Input.touchCount == 2) {
			x+=zpeed;
		}
		
		transform.position=new Vector3(x,transform.position.y,z);
		GlobalVars.herox=transform.position.x;
		GlobalVars.heroz=transform.position.z;
	}
}
