﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TriggerNextLevel : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("cilliding");
		if (other.gameObject.CompareTag ("Player")) {
			Scene currentScene = SceneManager.GetActiveScene();
			int numCurrentScene = currentScene.buildIndex;
			numCurrentScene++;
            SceneManager.LoadScene(numCurrentScene);
        }
	}
}
