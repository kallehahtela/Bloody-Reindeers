using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
{
    [Header("Car settings")]
    public float driftFactor = 0.95f;
    public float accelerateFactor = 30.0f;
    public float turnFactor = 3.5f;
    public float maxSpeed = 20f;
    float velocityVsUp = 0;

    float accelerationInput = 0;
    float steeringInput = 0;

    float rotationAngle = 0;

    Rigidbody2D carRigidBody2D;

    void Awake()
    {
        carRigidBody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ApplyEngineForce();

        KillOrthogonalVelocity();

        ApplySteering();
    }

    void ApplyEngineForce()
    {
        // calculate how much "forward" we are going in terms of the direction our velocity
        velocityVsUp = Vector2.Dot(transform.up, carRigidBody2D.velocity);

        // limit so we cannot go faster tham the max speed in the forward direction
        if (velocityVsUp > maxSpeed && accelerationInput > 0)
            return;

        // limit so we cannot go faster tham the 50% of the max speed in the reverse direction;
        if (velocityVsUp < -maxSpeed * 0.5f && accelerationInput < 0)
            return;

        // limit so we cannot go faster in any direction while accelerating
        if (carRigidBody2D.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
            return;

        // apply drag if there is no acceleration so the car stops when player lets go of the accelerator
        if (accelerationInput == 0)
        {
            carRigidBody2D.drag = Mathf.Lerp(carRigidBody2D.drag, 3.0f, Time.fixedDeltaTime * 3);
        }
        else
        {
            carRigidBody2D.drag = 0;
        }

        // create force amd pushesh the engine
        Vector2 engineForceVector = transform.up * accelerationInput * accelerateFactor;

        // apply force and pushes the car forward
        carRigidBody2D.AddForce(engineForceVector);
    }

    void ApplySteering()
    {
        // limit the cars ability to turn when moving slowly
        float minSpeedBeforeAllowTurningFactor = (carRigidBody2D.velocity.magnitude / 8);
        minSpeedBeforeAllowTurningFactor = Mathf.Clamp01(minSpeedBeforeAllowTurningFactor);

        // update the rotation angle based on input
        rotationAngle -= steeringInput * turnFactor * minSpeedBeforeAllowTurningFactor;

        // apply steering by rotating the car object
        carRigidBody2D.MoveRotation(rotationAngle);
    }

    void KillOrthogonalVelocity()
    {
        Vector2 forwardVelocity = transform.up * Vector2.Dot(carRigidBody2D.velocity, transform.up);
        Vector2 rightVelocity = transform.right * Vector2.Dot(carRigidBody2D.velocity, transform.right);

        carRigidBody2D.velocity = forwardVelocity + rightVelocity * driftFactor;
    }

    public void SetInputVector(Vector2 inputVector)
    {
        steeringInput = inputVector.x;
        accelerationInput = inputVector.y;
    }
}
