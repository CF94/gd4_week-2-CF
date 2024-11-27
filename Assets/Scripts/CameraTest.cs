using UnityEngine;

public class CameraTest : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraOffset;
    public Vector3 cameraRotation;
    Vector3 defaultCameraOffset;
    Vector3 defaultCameraRotation;

    bool firstPerson;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Method 3
        //defaultCameraOffset = playerTransform.position - transform.position;
        //transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        //Method 1
        //transform.position = playerTransform.position + cameraOffset;
        //transform.rotation = Quaternion.identity + cameraRotation;

        //Method 2

        //transform.position = playerTransform.position + new Vector3(0, 0, 0);

        //Method 3

        //transform.position = playerTransform.position + defaultCameraOffset;

        //Method 4

        transform.position = playerTransform.position + (playerTransform.forward * defaultCameraOffset.z) + new Vector3(0, 0, 0);

        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, playerTransform.eulerAngles.y, playerTransform.eulerAngles.z);

    }
}
