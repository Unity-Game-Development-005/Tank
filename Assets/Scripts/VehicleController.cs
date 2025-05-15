
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    // movement speed of vehicle
    [SerializeField] private float vehicleSpeed = 6f;

    // turn speed of vehicle
    //private float turnSpeed = 40f;


    // player controls
    
    // forward/reverse control
    //private float verticalInput;

    // turning control
    //private float horizontalInput;

    // player camera
    //public int playerIndex;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        //GetPlayerInput();

        MoveVehicle();
    }


    private void MoveVehicle()
    {
        // move the vehicle forward or backwards
        //transform.Translate(Time.deltaTime * vehicleSpeed * verticalInput * Vector3.forward);
        transform.Translate(Time.deltaTime * vehicleSpeed * Vector3.forward);

        // if the vehicle is moving forward, turn the vehicle normally
        /*
        if (verticalInput > 0f)
        {
            transform.Rotate(horizontalInput * Time.deltaTime * turnSpeed * Vector3.up);
        }

        // if the vehicle is reversing, reverse the vehicles turn direction
        else if (verticalInput < 0f)
        {
            transform.Rotate(horizontalInput * Time.deltaTime * turnSpeed * Vector3.down);
        }
        */


        if (transform.position.y < 0f)
        {
            transform.gameObject.SetActive(false);
        }
    }
}
