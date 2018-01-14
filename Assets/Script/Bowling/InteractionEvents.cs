using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionEvents : MonoBehaviour {

    private Vector3 pos;
    private Quaternion rotation;
    private int max_copy_count;
    
	// Use this for initialization
	void Start () {
        pos = gameObject.transform.position;
        rotation = gameObject.transform.rotation;
        max_copy_count = 1;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void on_grasp_begin(){
        Debug.Log("the object is grasped");
    }

    public void on_grasp_end(){
        Debug.Log("throwed");
        Destroy(gameObject,8.0f);
        Instantiate(gameObject,pos,rotation);
    }

    public void on_hover_begin(){
        Debug.Log("hover begin");
    }

    private void copy_object(){
        if(max_copy_count>0){
            Instantiate(gameObject,pos,rotation);
            max_copy_count--;
        }
    }

    public void on_contact_begin(){
        Debug.Log("contact the object!");
    }

    public void on_contact_end(){
        Destroy(gameObject,8.0f);
        Invoke("copy_object",1.2f);
    }
}
