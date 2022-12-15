using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNewGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void LoadA(string TrainingBase)
    {
        SceneManager.LoadScene(TrainingBase);
    }
}
