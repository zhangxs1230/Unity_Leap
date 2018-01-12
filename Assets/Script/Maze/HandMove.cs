using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity;

public class HandMove : MonoBehaviour
{

    GameObject little_guy;

    private Transform palm;
    private enum MoveDirection { Forward = 1, Left = 2, Right = 3 }

    // these two variables are used to control the speed of moving
    private float rotation_speed = 0.4f;
    private float translation_speed = 0.08f;

    private MoveDirection _direction;

    // Use this for initialization
    void Start()
    {
        palm = GetComponent<RigidHand>().palm;
        little_guy = transform.parent.parent.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        get_direction();
        if (_direction == MoveDirection.Forward)
        {
            translate();
        }
        if (_direction == MoveDirection.Left || _direction == MoveDirection.Right)
        {
            rotate();
        }
    }

    ///<summary>
    /// these functions are used to determine the action of next move
    /// to turn left or turn right or move Forward
    ///</summary>
    private float abs(float value) { return value > 0 ? value : -value; }
    private int max(Vector3 v)
    {
        int max_axes;
        v.x = abs(v.x) > abs(v.z) ? abs(v.x) : abs(v.z);
        max_axes = v.x > abs(v.y) ? 0 : 1;
        return max_axes;
    }
    private void get_direction()
    {
        Vector3 isleft = Vector3.Cross(palm.forward,palm.up);
        if (max(palm.up) == 1)
        {
            if (palm.up.y > 0)
                _direction = MoveDirection.Forward;
        }
        else if (isleft.y < 0)
        {
            _direction = MoveDirection.Left;
        }
        else
        {
            _direction = MoveDirection.Right;
        }
    }

    ///<summary>
    /// these functions are used to excute the action of next move
    ///</summary>
    public void rotate()
    {
        if (_direction == MoveDirection.Left)
        {
            //Debug.Log("Left" + Time.frameCount);
            little_guy.transform.Rotate(0f, -rotation_speed, 0f);
        }
        if (_direction == MoveDirection.Right)
        {
            //Debug.Log("Right" + Time.frameCount);
            little_guy.transform.Rotate(0, rotation_speed, 0);
        }
    }

    public void translate()
    {
        float angle = little_guy.transform.rotation.y;
        little_guy.transform.Translate((float)(translation_speed*System.Math.Sin(angle)),
            0f,(float)(translation_speed*System.Math.Cos(angle)));
    }
}
