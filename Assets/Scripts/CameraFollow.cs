using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float rotationSpeed;
    public Vector3 offset;
    public Transform target;
    public float smoothLerp = 0.140f;
    public GameObject focal;

    public float mouseX;
    public float mouseY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 targetPosition = target.position + offset;
        Vector3 positionLerp = Vector3.Lerp(transform.position, targetPosition, smoothLerp);
        transform.position = positionLerp;


        
    


    }
}
