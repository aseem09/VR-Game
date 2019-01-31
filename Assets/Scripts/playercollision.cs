using UnityEngine;

public class playercollision : MonoBehaviour {

	public Move movement;


	void OnCollisionEnter (Collision collisioninfo)
	{
		if (collisioninfo.collider.tag == "Obstacle") {
			Debug.Log ("Hello");
				movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame ();
		}
	}
}
