using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {


    Transform target;
    HeadLookController controller;

	// Use this for initialization
	void Start () {
        controller = GetComponent<HeadLookController>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (target != null)
        {
            return;
        }

        if (other.CompareTag("Player"))
        {
            Debug.Log("hit!");
            target = other.transform;
        }
    }
    // Update is called once per frame
    void LateUpdate () {
		if (target != null)
        {
            controller.target = target.position;
        }
	}
}
