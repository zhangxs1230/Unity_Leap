using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuButtons : MonoBehaviour {
    public GameObject Canvas;
	// Use this for initialization
	void Start () {
		Canvas = transform.parent.parent.gameObject;
		//btn.onClick.AddListener(() => { Application.LoadLevel("Maze"); }); 
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

	public void open_setting(){
		GameObject SettingMenu = Canvas.transform.Find("SettingMenu").gameObject;
		if(SettingMenu.activeSelf==false){
			SettingMenu.SetActive(true);
		}
	}
	public void close_setting(){
		gameObject.transform.parent.gameObject.SetActive(false);
	}

    public void exit(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
