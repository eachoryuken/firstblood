using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	void OnGUI () {
		if(!GlobalVars.menu){
			GUI.Box(new Rect(10,10,100,90), "Hello");
			if(GUI.Button(new Rect(20,40,80,20), "New Game")) {
				GlobalVars.menu=true;
				OnGUI ();
			}
			if(GUI.Button(new Rect(20,70,80,20), "Quit")) {
				
			}
		}
		else{
			GUI.Box(new Rect(10,10,100,90), "Dificuldade");
			if(GUI.Button(new Rect(20,40,80,20), "Easy")) {
				GlobalVars.velop=0.05f;
				Application.LoadLevel(1);
				GlobalVars.menu=false;
				
			}
			if(GUI.Button(new Rect(20,70,80,20), "Hard")) {
				GlobalVars.velop=0.1f;
				Application.LoadLevel(1);
				GlobalVars.menu=false;
			}
		}
	}
}