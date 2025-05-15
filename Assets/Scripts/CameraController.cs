
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // controller script to allow the camera to follow the player

    // gameobject for the camera to follow
    public Transform playerVehicle;

    // main camera position
    private Vector3 cameraPosition;

    // third person camera follow offset position
    private Vector3 firstPersonCameraOffestPosition = new Vector3(0, 4, 3);

    // first person camera follow offset position
    private Vector3 thirdPersonCameraOffestPosition = new Vector3(0, 10, -10);

    // bool to switch camera pov
    // true = first person / false = third person  
    private bool isFirstPersonCamera;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // set the initial pov of the camera to third person
        cameraPosition = thirdPersonCameraOffestPosition;

        // position the camera
        transform.position = playerVehicle.position + cameraPosition;

        // set first person camera flag to false
        isFirstPersonCamera = false;
    }


    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
    }


    // position the camera based on player input
    private void GetPlayerInput()
    {
        // if the player presses the 'P' key       
        if (Input.GetKeyDown(KeyCode.P))
        {
            // and 'first person camera' is set
            if (!isFirstPersonCamera)
            {
                // change pov of camera to first person
                cameraPosition = firstPersonCameraOffestPosition;

                isFirstPersonCamera = true;
            }


            // otherwise
            else
            {
                // change pov of camera to third person
                cameraPosition = thirdPersonCameraOffestPosition;

                isFirstPersonCamera = false;
            }
        }
    }


    // follow the player with the camera
    private void LateUpdate()
    {
        transform.position = playerVehicle.position + cameraPosition;
    }
}
