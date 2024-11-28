using UnityEngine;

public class CameraFollowNew : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;
    public Transform playerTransform;
    private Vector3 offset =  new Vector3(0, 2, -5);

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + (playerTransform.forward * offset.z) + new Vector3 (0, offset.y, 0);
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, playerTransform.eulerAngles.y, transform.eulerAngles.z);
    }
}
