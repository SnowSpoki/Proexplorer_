using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {
	public void LoadbyIndex (int sceneIndex)
	{
		SceneManager.LoadScene (sceneIndex);
	}
}