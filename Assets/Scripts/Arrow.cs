using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
    public Image pointArrow;
    public Transform[] waypoints;
    Transform q;

    public Camera cam;

    private Vector2 pointPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FindWaypoints();
    }

    void FindWaypoints()
    {
        waypoints = new Transform[transform.childCount];

        int i = 0;

        foreach (Transform t in transform)
        {
            waypoints[i++] = t;
        }


        if (waypoints[0] != null)
        {
            pointPosition = cam.WorldToScreenPoint(waypoints[0].position);
            pointPosition.x = Mathf.Clamp(pointPosition.x, 0.0f, Screen.width);
            pointPosition.y = Mathf.Clamp(pointPosition.y, 0.0f, Screen.height);
            pointArrow.transform.position = pointPosition;
        }
        else
        {
            pointArrow.enabled = false;
        }
    }
}
