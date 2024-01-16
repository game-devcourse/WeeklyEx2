using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Tooltip("In what speed to rotate")]
    [SerializeField]
    public float RotationSpeed = 20.0f;

    [Tooltip("On which scale to rotate X, Y or Z")]
    [SerializeField]
    char scale ;
    
// private Vector3 initPlace;

    // void Start()
    // {
    //     initPlace = GetComponent<Transform>().rotation;


    // }
    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(
        //                     Vector3.right * RotationSpeed * Time.deltaTime +
        //                     Vector3.up * RotationSpeed * Time.deltaTime +
        //                     Vector3.forward * RotationSpeed * Time.deltaTime,
        //                     Space.Self
        //                 );
        switch(scale)
        {
            case 'X':
                transform.Rotate(Vector3.right * RotationSpeed * Time.deltaTime);
                //transform.rotation = initPlace;
                break;
            case 'Y':
                transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
                //transform.rotation = initPlace;
                break;
            case 'Z':
                transform.Rotate(Vector3.forward * RotationSpeed * Time.deltaTime);
                //transform.rotation = initPlace;
                break;
        }
    }
}
