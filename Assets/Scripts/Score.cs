using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text score;
	public GameObject player; 

	void Start(){

	}

	void Update () {
		int c = (int)player.transform.position.z;
		score.text = c.ToString ();
	}
}
