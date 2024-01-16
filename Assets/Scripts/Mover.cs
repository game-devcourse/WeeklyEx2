using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerA : MonoBehaviour
{
    [Tooltip("Step size in meters")] [SerializeField] float stepSize = 1f;

    [SerializeField]
    InputAction moveUp = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveDown = new InputAction(type: InputActionType.Button);
    
    [SerializeField]
    InputAction moveLeft = new InputAction(type:InputActionType.Button);

    [SerializeField]
    InputAction moveRight = new InputAction(type:InputActionType.Button);

    void OnEnable()
    {
        moveUp.Enable();
        moveDown.Enable();
        moveLeft.Enable();
        moveRight.Enable();
    }

     void OnDisable()
    {
        moveUp.Disable();
        moveDown.Disable();
        moveLeft.Disable();
        moveRight.Disable();
    }

    // Update is called once per frame
    void Update()
    {
if (moveUp.WasPressedThisFrame()) 
            transform.position += new Vector3(0, stepSize, 0);
        if (moveDown.WasPressedThisFrame()) 
            transform.position += new Vector3(0, -stepSize, 0);
        if (moveLeft.WasPressedThisFrame()) 
            transform.position += new Vector3(-stepSize, 0, 0);
        if (moveRight.WasPressedThisFrame()) 
            transform.position += new Vector3(stepSize, 0, 0);
    }
}