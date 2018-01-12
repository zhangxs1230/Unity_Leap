using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardTranslate : MonoBehaviour {

    public float translation_speed = 10f;
    private CharacterController con;

	// Use this for initialization
	void Start () {
        con = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
			float nextX = Input.GetAxis ("Horizontal") * translation_speed * Time.deltaTime;
			float nextZ = Input.GetAxis ("Vertical") * translation_speed * Time.deltaTime;
			//transform.Translate(nextX, 0, nextZ);
			Vector3 movement = new Vector3 (nextX, 0, nextZ);
			movement = transform.TransformDirection (movement);//把本地空间转化为全局空间
			movement.y = -9.8f;//设置重力，使其不能漂浮
			con.Move (movement);
	}
}
