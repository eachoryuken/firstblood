using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {	
	void OnGUI(){
		string printscore="Player 1 \n"+GlobalVars.score;
		GUI.Box(new Rect(0,0,100,50), printscore);
	}
}
