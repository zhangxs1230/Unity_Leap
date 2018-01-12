using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour {

    public GameObject Canvas;
	// Use this for initialization
	void Start () {
		Canvas = transform.parent.parent.gameObject;
	}

    public void open_introduction(){
        GameObject IntroductionMenu = Canvas.transform.Find("IntroductionMenu").gameObject;
        if(IntroductionMenu.activeSelf==false){
            IntroductionMenu.SetActive(true);
        }
    }
    public void close_introduction(){
        gameObject.transform.parent.gameObject.SetActive(false);
    }
}
