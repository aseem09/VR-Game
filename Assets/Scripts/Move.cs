using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	public Rigidbody player;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		player.AddForce (0, 0, 20);
		if (Input.GetKey ("d")) {
			player.AddForce (1, 0, 0, ForceMode.VelocityChange );
		}
		if (Input.GetKey ("a")) {
			player.AddForce (-1, 0, 0,ForceMode.VelocityChange);
		}
		if (player.transform.position.y <= -1) {
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
