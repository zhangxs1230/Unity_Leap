using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {

	private AudioSource m_as;
	// Use this for initialization
	void Start () {
		m_as = gameObject.GetComponent<AudioSource> ();
		m_as.volume = SoundManager.Instance.volumn;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (SoundManager.Instance.enable) {
			m_as.Play ();
		} else {
			m_as.Stop();
		}
	}
}
