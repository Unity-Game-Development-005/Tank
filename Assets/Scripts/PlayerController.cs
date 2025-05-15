
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // movement speed of vehicle
    private float vehicleSpeed = 6f;

    // turn speed of vehicle
    private float turnSpeed = 40f;


    // player controls
    
    // forward/reverse control
    private float verticalInput;

    // turning control
    private float horizontalInput;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
    }


    // get player input
    private void GetPlayerInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        verticalInput = Input.GetAxis("Vertical");

        MoveVehicle();
    }


    private void MoveVehicle()
    {
        // move the vehicle forward or backwards
        transform.Translate(Vector3.forward * verticalInput * vehicleSpeed * Time.deltaTime);

        // if the vehicle is moving, allow it to turn
        if (verticalInput != 0f)
        {
            transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);
        }
    }
}
