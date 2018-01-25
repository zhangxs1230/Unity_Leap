using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEvents : MonoBehaviour {

    private GameObject finish;
	// Use this for initialization
	void Start () {
        finish = GameObject.Find("Canvas").transform.Find("Finish").gameObject;
        finish.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(){
        Debug.Log("Collections!");
        finish.SetActive(true);
    }

    public void close_finish(){
        finish.SetActive(false);
    }
}
