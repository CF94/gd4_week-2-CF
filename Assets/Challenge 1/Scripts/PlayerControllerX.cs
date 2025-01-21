using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject player;
    public float speed = 50f;
    public float rotationSpeed = 45f;
    public string playerIndex;
    //public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        float horizontalInput = Input.GetAxis("Horizontal" + playerIndex);
        float verticalInput = Input.GetAxis("Vertical" + playerIndex);

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * horizontalInput, Space.World);
        
        if (Input.GetKey("space"))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey("left shift"))
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        }

                        }
}
