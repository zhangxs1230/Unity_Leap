using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonEvents : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// GetComponent<Button>().onClick.AddListener(()=>{
        //     Debug.Log("strat");
        // });
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void press_1(){
        Debug.Log("press1");
    }

    public void press_2(){
        Debug.Log("press2");
    }
}
