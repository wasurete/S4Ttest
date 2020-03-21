using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazardous: MonoBehaviour 
{
   	void OnCollisionEnter(Collision collision)
	{
		 if (collision.gameObject.tag == "Player") 
		{ 
	          GameManager.isGameOver = true; 
	     } 
   } 
}




