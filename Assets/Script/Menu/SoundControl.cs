using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundControl : MonoBehaviour {

	public Slider targetSliderObject;
	public Toggle targetToggleObject;

	// Use this for initialization
	void Start () {
		if(SoundManager.Instance==null) {
		    SoundManager.Instance.volumn = targetSliderObject.value;
		    SoundManager.Instance.enable = targetToggleObject.isOn;
        }
        else{
            targetSliderObject.value = SoundManager.Instance.volumn;
		    targetToggleObject.isOn = SoundManager.Instance.enable;
        }
	}
	
	// Update is called once per frame
	void Update () {
		SoundManager.Instance.volumn = targetSliderObject.value;
		SoundManager.Instance.enable = targetToggleObject.isOn;
	}
}
