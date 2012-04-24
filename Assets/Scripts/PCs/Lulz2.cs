using UnityEngine;
using System.Collections;

public class Lulz2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float z=transform.position.z;
		float x=transform.position.x;
	
		if(Input.GetKey("u")){z+=0.2f;}
		if(Input.GetKey("j")){z-=0.2f;}
		if(Input.GetKey("h")){x-=0.2f;}
		if(Input.GetKey("k")){x+=0.2f;}
		
		transform.position=new Vector3(x,transform.position.y,z);
	}
}
