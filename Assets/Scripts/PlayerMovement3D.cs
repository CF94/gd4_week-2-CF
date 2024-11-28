using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement3D : MonoBehaviour
{
    public GameObject player;
    public Vector3 spawnPosition;
    public float movementSpeed = 10f;
    public float maxSpeed = 50f;
    public float turnSpeed = 45f;
    //float vertical, horizontal;

    //public float rotationSpeed = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 playerMovement = new Vector3
            //(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            
           // transform.Translate(playerMovement * maxSpeed * Time.deltaTime);

        //if (Input.GetAxis("Vertical") != 0)
        {

            //this will increase the move speed when you have forward or backward button pressed down
            movementSpeed += Time.deltaTime * 0.2f;
        }
        //else
        {
            //this will reset the movement speed to 10 (this could be any number you want)
            movementSpeed = 10;
        }

        //float horizontalInput = Input.GetAxis("Horizontal");

        //transform.Rotate(0, horizontalInput * rotationSpeed * Time.deltaTime, 0);
                     
        //Horizontal Input (Left - Right)
        float horizontal = Input.GetAxis("Horizontal");

        //Vertical Input (Up - Down/ Forwards - Backwards)
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime * vertical);
        transform.Rotate(Vector3.up * turnSpeed * horizontal * Time.deltaTime);

    }
}
