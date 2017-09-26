using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour {

    public Transform subjectOverride;
    public Transform waypointOverride;
    public bool endTrigger;

	void OnTriggerEnter(Collider col)
    {
        Debug.Log("Camera change activated at " + name + " by " + col.name);
        CameraController camControl = Camera.main.GetComponent<CameraController>();

        if(waypointOverride != null)
        {
            camControl.waypoint = waypointOverride;
        }
        if(subjectOverride != null)
        {
            camControl.subject = subjectOverride;
        }

        if(endTrigger)
        {
            camControl.Victory();
        }
    }

    void OnDrawGizmos()
    {
        if (waypointOverride != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(transform.position, waypointOverride.position);
        }

        if (subjectOverride != null)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawLine(transform.position, subjectOverride.position);
        }
    }
}
