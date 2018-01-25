using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundInMaze : MonoBehaviour {
	private AudioSource m_as;
	// Use this for initialization
	void Start () {
		m_as = gameObject.GetComponent<AudioSource> ();
		if (SoundManager.Instance.enable) {
			m_as.volume = SoundManager.Instance.volumn;
			m_as.Play ();
		} else {
			m_as.Stop();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
