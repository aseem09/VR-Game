using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

	bool ended=false;
	// Use this for initialization
	public void EndGame(){
		if (ended == false) {
			ended = true;
			Invoke ("Restart", 2f);
		}
	}
	void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		Debug.Log ("Restart");
	}
}
