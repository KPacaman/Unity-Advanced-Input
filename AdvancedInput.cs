using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedInput : MonoBehaviour
{
    #region Movement
    static float getAxisH = 0;
    static float getAxisV = 0;
    public static float GetAxis(string direction, KeyCode forward, KeyCode back, KeyCode right, KeyCode left, float acceleration = 2)
    {
        if (direction == "Vertical")
        {
            if (Input.GetKey(forward))
            {
                getAxisV = Mathf.MoveTowards(getAxisV, 1, acceleration * Time.deltaTime);
            }
            else if (Input.GetKey(back))
            {
                getAxisV = Mathf.MoveTowards(getAxisV, -1, acceleration * Time.deltaTime);
            }
            else
            {
                getAxisV = Mathf.MoveTowards(getAxisV, 0, acceleration * Time.deltaTime);
            }
            return getAxisV;
        }
        if (direction == "Horizontal")
        {
            if (Input.GetKey(right))
            {
                getAxisH = Mathf.MoveTowards(getAxisH, 1, acceleration * Time.deltaTime);
            }
            else if (Input.GetKey(left))
            {
                getAxisH = Mathf.MoveTowards(getAxisH, -1, acceleration * Time.deltaTime);
            }
            else
            {
                getAxisH = Mathf.MoveTowards(getAxisH, 0, acceleration * Time.deltaTime);
            }
            return getAxisH;
        }
        else
        {
            Debug.LogError("Invalid axis! Use \"Horizontal\" or \"Vertical\"");
        }
        return 0;
    }

    static float getAxisRawH = 0;
    static float getAxisRawV = 0;
    public static float GetAxisRaw(string direction, KeyCode forward, KeyCode back, KeyCode right, KeyCode left)
    {
        if (direction == "Vertical")
        {
            if (Input.GetKey(forward))
            {
                getAxisRawV = 1;
            }
            else if (Input.GetKey(back))
            {
                getAxisRawV = -1;
            }
            else
            {
                getAxisRawV = 0;
            }
            return getAxisRawV;
        }
        if (direction == "Horizontal")
        {
            if (Input.GetKey(right))
            {
                getAxisRawH = 1;
            }
            else if (Input.GetKey(left))
            {
                getAxisRawH = -1;
            }
            else
            {
                getAxisRawH = 0;
            }
            return getAxisRawH;
        }
        else
        {
            Debug.LogError("Invalid axis! Use \"Horizontal\" or \"Vertical\"");
        }
        return 0;
    }
    #endregion
}
