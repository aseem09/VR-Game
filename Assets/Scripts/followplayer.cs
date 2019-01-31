using UnityEngine;

public class followplayer : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	public Vector3 offset;
	void Start () {
		//offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + offset;
	}
}
