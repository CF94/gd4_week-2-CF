using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Transform planeTransform;
    private int front = 0;
    private int side = 1;
    private Vector3 offsetSide = new Vector3(50, 0, 0);
    //private Vector3 offsetFront = new Vector3(0, 0, 50);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offsetSide;
    }
}
