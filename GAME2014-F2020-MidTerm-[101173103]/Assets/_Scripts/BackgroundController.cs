// BackgroundController.cs
// Raven Powless - 101173103
// Date last modified: October 20, 2020
// Description: Script used to set characteristics/behaviour of scrolling background

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;

    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _MoveHorizontal();
        _CheckBoundsHorizontal();
    }

    private void _ResetVertical()
    {
        transform.position = new Vector3(0.0f, verticalBoundary);
    }

    private void _ResetHorizontal()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    private void _MoveVertical()
    {
        transform.position -= new Vector3(0.0f, verticalSpeed) * Time.deltaTime;
    }

    private void _MoveHorizontal()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBoundsVertical()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.y <= -verticalBoundary)
        {
            _ResetVertical();
        }
    }

    private void _CheckBoundsHorizontal()
    {
        // if background has reached side of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _ResetHorizontal();
        }
    }
}
