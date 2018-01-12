using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MouseRotate : MonoBehaviour
{

    public float rotation_speed = 5f;
    public float minVert = -40.0f;
    public float maxVert = 45.0f;
    private float nextX = 0;
    private float nextY = 0;

    public enum RotationAxes
    {
        MouseXandY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxes axes = RotationAxes.MouseXandY;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (axes == RotationAxes.MouseX)
            transform.Rotate(0, Input.GetAxis("Mouse X") * rotation_speed, 0);
        else if (axes == RotationAxes.MouseY)
        {
            nextX -= Input.GetAxis("Mouse Y") * rotation_speed;
            nextX = Mathf.Clamp(nextX, minVert, maxVert);
            nextY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(nextX, nextY, 0);
        }
        else
        {
            nextX -= Input.GetAxis("Mouse Y") * rotation_speed;
            nextX = Mathf.Clamp(nextX, minVert, maxVert);
            nextY += Input.GetAxis("Mouse X") * rotation_speed;
            transform.localEulerAngles = new Vector3(nextX, nextY, 0);
        }
    }

}
