using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class RigidBodyMovement : MonoBehaviour
{
    public float speed = 20f;
    //public float maxSpeed = 50.f;
    public float turnSpeed = 45f;
    public float horizontal;
    public float vertical;
    Rigidbody rb;
    public string playerIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal" + playerIndex);
        float vertical = Input.GetAxis("Vertical" + playerIndex);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up, turnSpeed * horizontal * Time.deltaTime);
        rb.AddForce(Vector3.forward * speed);
    }
}
