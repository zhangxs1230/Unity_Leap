using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionEvents : MonoBehaviour {

	// Use this for initialization

    private Vector3 pos;
    private Quaternion rotation;
    private int pre_frame;
    private int cur_frame;
	void Start () {
		Debug.Log(gameObject.GetType());
        pos = gameObject.transform.position;
        rotation = gameObject.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        cur_frame = Time.frameCount;
        if(cur_frame-pre_frame>60){
            Instantiate(gameObject,pos,rotation);
        }
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

    public void on_contact_begin(){
        Debug.Log("contact the object!");
        pre_frame = Time.frameCount;
        Debug.Log(pre_frame);
    }

    public void on_contact_end(){
        Debug.Log(cur_frame);
        Destroy(gameObject,8.0f);
    }
}
