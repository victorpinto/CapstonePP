using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerCamera180LockScript : MonoBehaviour {

    
    private Cinemachine.CinemachineFreeLook playerVirtualCamera;

    // From Cinemachine Dev
    /*
    [Range(0, 360)]
    private float deadZoneSize = 180;
    */
 

	// Use this for initialization
	void Start () {
        playerVirtualCamera = transform.GetComponent<Cinemachine.CinemachineFreeLook>();


        
    }
	

    

	// Update is called once per frame
	void Update () {

        //CinemachineCore.GetInputAxis().;
        // left = 90
        // right = 270

        //90<->180<->270 == NO!!

        /////////////////////////////////////////////////////

        // From Cinemachine Dev
        /*
        float halfDeadZone = deadZoneSize / 2;
        float axisXValue = playerVirtualCamera.m_XAxis.Value;

        if (axisXValue > 180)
        {
            axisXValue = Mathf.Max(axisXValue, 180 + halfDeadZone);
        }
        if (axisXValue < 180)
        {
            axisXValue = Mathf.Min(axisXValue, 180 - halfDeadZone);
        }

        playerVirtualCamera.m_XAxis.Value = axisXValue;
        */

        //////////////////////////////////////////////////////////////////
        
        if (playerVirtualCamera.m_XAxis.Value >= 90 && playerVirtualCamera.m_XAxis.Value <= 270)
        {
            if (playerVirtualCamera.m_XAxis.Value >= 90 && playerVirtualCamera.m_XAxis.Value < 181)
            {

                //90
                playerVirtualCamera.m_XAxis.Value = 90.0f;
                //playerVirtualCamera.m_XAxis.m_AccelTime = 0;
                
                //Debug.Log("Entered1");
            }


            else if (playerVirtualCamera.m_XAxis.Value <= 270 && playerVirtualCamera.m_XAxis.Value > 179)
            {
                // 270
                playerVirtualCamera.m_XAxis.Value = 270.0f;
               // Debug.Log("Entered2");
            } 
        }
        
        
        ////////////////////////////////////////////////////////

        //playerVirtualCamera.m_XAxis.Value = Mathf.Clamp(playerVirtualCamera.m_XAxis.Value, 90, 270);

    }

    /*
    public float GetAxisCustom(string axisName)
    {
        Debug.Log("FART");
        if (axisName == "Horizontal")
        {
            return -UnityEngine.Input.GetAxis("Horizontal");
        }
        else
            return UnityEngine.Input.GetAxis(axisName);
    }
    */
    /*
    private float GetAxisCustom(string axisName)
    {
        Debug.Log("Hoi!");
        if (axisName == "RightStickX")
        {
            Debug.Log("it has found right!");
            if (playerVirtualCamera.m_XAxis.Value >= 90 && playerVirtualCamera.m_XAxis.Value <= 270)
            {
                Debug.Log("It was discoverd");
                return 0;   
            }
            else
                return Input.GetAxis("RightStickX");
        }
        else
            return 0;
    }

    */

    //Deffault Axis controls (X axis -> Input Axis Name = Mouse X, Y axis -> Input Axis Name = Mouse Y)

}
