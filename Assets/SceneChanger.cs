using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour { 
	  public int sceneIndex; 
	  public void ChangeScene(){ 
		    SceneManager.LoadScene (sceneIndex);
	  } 
}