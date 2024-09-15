using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 45f;
    [SerializeField] private Transform rotateAround;

    private float currentRotationSpeed;

    void Start()
    {
        currentRotationSpeed = rotationSpeed;
    }

    void Update()
    {
        this.transform.RotateAround(rotateAround.position, Vector3.forward, currentRotationSpeed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.Q))
        {
            currentRotationSpeed = rotationSpeed;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            currentRotationSpeed = -rotationSpeed; 
        }
    }
}

