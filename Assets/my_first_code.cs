using UnityEngine;

public class my_first_code : MonoBehaviour {
	public int myAge;
	void Start () {
		Debug.Log ("hello world");
		Debug.Log ("My name is brin");
		myAge = 0;
	}
			void Update () {
		if (myAge < 100) {
			Debug.Log ("I am not " + myAge + " years old.");
		}
		if (myAge == 100) {
			Debug.Log ("I am " + myAge + " years old.");
		}
		myAge++;
	}
}