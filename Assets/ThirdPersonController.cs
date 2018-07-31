using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ThirdPersonController : MonoBehaviour {

    // Serialized Fields
    // Player Attributes
    [SerializeField]
    private float Acceleration = 2;
    [SerializeField]
    private float backwardMultiplayer = 0.5f;
    [SerializeField]
    private float sprintMultiplayer = 2;
    [SerializeField]
    private float springInitialLength = 2;
    [SerializeField]
    private float Mass = 10;

    // Objects
    [SerializeField]
    private Camera playerCamera;

    // non - Serialized Fields


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 bodyRotation = new Vector3(0, playerCamera.transform.eulerAngles.y, 0);

        transform.rotation = Quaternion.Euler(bodyRotation);

	}
}
