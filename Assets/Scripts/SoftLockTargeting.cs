using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftLockTargeting : MonoBehaviour {

    private GameObject softLockTarget;

    private float softLockMaxDistance;

    //private GameObject player;


    Ray softLockRaycast;


    // Use this for initialization
    void Start () {
        softLockRaycast = new Ray(transform.position, Vector3.forward));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
