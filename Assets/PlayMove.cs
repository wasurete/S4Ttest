using UnityEngine;

public class PlayMove : MonoBehaviour {
	void Update () {
		transform.position += new Vector3 (Input.GetAxis ("Horizontal")*0.2f,0, Input.GetAxis ("Vertical")*0.2f); 
	}
}
