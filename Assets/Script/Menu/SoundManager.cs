using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static SoundManager Instance;
	public float volumn;
	public bool enable;
	void Awake(){
		if (Instance == null) {
			Instance = this;
		} else if (Instance != null) {
			Destroy (gameObject);
		}
		GameObject.DontDestroyOnLoad (gameObject);
	}
}
