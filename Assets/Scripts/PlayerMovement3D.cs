using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement3D : MonoBehaviour
{
    public GameObject player;

    public Vector3 spawnPosition;

    public float moveSpeed = 10;

    public float rotationSpeed = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerMovement = new Vector3
            (Input.GetAxis("Horizontal"), 
            0,
            (Input.GetAxis("Vertical")));
        transform.Translate(playerMovement * moveSpeed * Time.deltaTime);

        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(0, horizontalInput * rotationSpeed * Time.deltaTime, 0);
    }
}
