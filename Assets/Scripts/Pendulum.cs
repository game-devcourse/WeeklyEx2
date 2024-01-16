using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class Pendulum : MonoBehaviour
{
    [Tooltip("How high the movment would be")]
    [SerializeField]
    float length = 5f;      

    [Tooltip("What will be the angle for the movment")]
    [SerializeField]
    float initialAngle = 45f;     

    [Tooltip("Adjust this value to control the speed of the pendulum swing")]
    [SerializeField]
    private float speed = 6;

    private Vector3 center;

    // Start is called before the first frame update
    void Start()
    {
        center = GetComponent<Transform>().position;

    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the angular displacement based on time and swing speed
        float angularDisplacement = Mathf.PingPong(Time.time * speed, 1f);

        // Map the displacement to the desired angle range
        float angle = Mathf.Lerp(-initialAngle, initialAngle, angularDisplacement);

        // Convert the angle to radians
        float radianAngle = Mathf.Deg2Rad * angle;

        // Calculate the position of the pendulum bob
        float xPos = center.x + length * Mathf.Sin(radianAngle);
        float yPos = center.y - length * Mathf.Cos(radianAngle);

        // Set the position of the pendulum bob
        transform.position = new Vector3(xPos, yPos, 0f);   
    }
}