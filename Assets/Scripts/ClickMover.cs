using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickMover : MonoBehaviour
{
    [Tooltip("Step size in meters")] [SerializeField] float stepSize = 1f;

    [SerializeField]
    InputAction moveUp = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveDown = new InputAction(type: InputActionType.Button);
    
    [SerializeField][Tooltip("move the plyer to the location of 'moveToLocation'.")]
    InputAction moveTo = new InputAction(type:InputActionType.Button);

    [SerializeField][Tooltip("Determine the locatin to 'moveTo'.")]
    InputAction moveToLocatin = new InputAction(type: InputActionType.Value, expectedControlType: "Vector2");

    void OnValidate(){
        if(moveTo.bindings.Count == 0)
            moveTo.AddBinding("<Mouse>/leftButton");
         if(moveToLocatin.bindings.Count == 0)
            moveToLocatin.AddBinding("<Mouse>/position");
    }

    void OnEnable()
    {
        moveUp.Enable();
        moveDown.Enable();
        moveTo.Enable();
        moveToLocatin.Enable();
    }

     void OnDisable()
    {
        moveUp.Disable();
        moveDown.Disable();
        moveTo.Disable();
        moveToLocatin.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moveUp.WasPressedThisFrame()){
            transform.position += new Vector3(0, stepSize, 0);
        } else if (moveDown.WasPressedThisFrame()){
            transform.position += new Vector3(0, -stepSize, 0);
        } else if (moveTo.WasPressedThisFrame()){
            Vector2 mousePositionInScreenCoordinates = moveToLocatin.ReadValue<Vector2>();  
            Vector3 mousePositionInWorldCoordinates = Camera.main.ScreenToWorldPoint(mousePositionInScreenCoordinates);
            mousePositionInWorldCoordinates.z = transform.position.z;
            transform.position = mousePositionInWorldCoordinates;
        }

    }
}