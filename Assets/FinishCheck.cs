using UnityEngine;

public class FinishCheck : MonoBehaviour {
  public GameObject tint; 
  public GameObject mainText; 
  void OnCollisionEnter(){    
	tint.SetActive (true);    
	mainText.SetActive (true); 
  }
}