using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour {

	// Use this for initialization
    public string SceneName;
	void Start () {
		GetComponent<Button>().onClick.AddListener(()=>{
            Debug.Log(SceneName+" scene loading");
            SceneManager.LoadScene(SceneName);
        });
	}
}
