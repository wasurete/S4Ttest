using UnityEngine;

public class Breaker : MonoBehaviour {  
  public GameObject wall;
  void OnCollisionEnter(){       
	Destroy (wall); 
  }
}