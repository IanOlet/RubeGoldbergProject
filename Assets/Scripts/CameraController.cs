using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform subject;
    public Transform waypoint;
    public GameObject stopper;
    public GameObject startText;
    public GameObject winText;
	
	// Update is called once per frame
	void Update () {
		if (subject != null)
        {
            transform.LookAt(subject);
        }
        if (waypoint != null)
        {
            Vector3 moveDirection = waypoint.transform.position - transform.position;
            if(moveDirection.magnitude > 1)
            {
                moveDirection = Vector3.Normalize(moveDirection);
            }

            transform.position += moveDirection * Time.deltaTime * 6f;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startText.SetActive(false);
            stopper.SetActive(false);
        }
	}

    public void Victory()
    {
        winText.SetActive(true);
    }

}
