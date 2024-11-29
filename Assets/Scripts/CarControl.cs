using UnityEngine;

public class CarControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 20f;
    //public float maxSpeed = 50.f;
    public float turnSpeed = 45f;
    //public float horizontalInput;
    //public float verticalInput;
    Rigidbody rb;
    // Player index refers to assigning player values (ie Player 1, Player 2 etc).
    public string playerIndex;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal" + playerIndex);
        float vertical = Input.GetAxis("Vertical" + playerIndex);
        //horizontal = Input.GetAxis("Horizontal");
        //vertical = Input.GetAxis("Vertical");

        if (Input.GetAxis("Vertical" + playerIndex) != 0)
        {
            //this will increase the move speed when you have forward or backward button pressed down
            speed += Time.deltaTime * 1f;
        }
        else
        {
            //this will reset the movement speed to 10 (this could be any number you want)
            speed = 20;
        }
                       
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up, turnSpeed * horizontal * Time.deltaTime);

        //rb.AddForce(Vector3.forward * speed)
    }
}
