using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;

    private int desiredLane = 1;//0:left 1:middle 2:right
    public float laneDistance = 4;//the distance between two lanes

    public float jumpForce;
    public float Gravity = -50;

    private float startAccel; // Aceleración inicial del giroscopio

    void Start()
    {
        controller = GetComponent<CharacterController>();

        Input.gyro.enabled = true; // Habilitar el giroscopio
        startAccel = Input.acceleration.x; // Obtener la aceleración inicial
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerManager.isGameStarted)
            return;

        direction.z = forwardSpeed;

        if (controller.isGrounded)
        {
            direction.y = -1;
            if (SwipeManager.swipeUp)
            {
                Jump();
            }
        }
        else
        {
            direction.y += Gravity * Time.deltaTime;
        }
        // Usar el giroscopio para cambiar de carril
        float currentAccel = Input.acceleration.x;
        if (Mathf.Abs(currentAccel - startAccel) > 0.27f)
        {
            if (currentAccel > startAccel)
            {
                MoveLaneRight();
            }
            else
            {
                MoveLaneLeft();
            }
            startAccel = currentAccel;
        }

        //Gather the inputs on which lane we should be

        if (SwipeManager.swipeRight)
        {
            desiredLane++;
            if (desiredLane == 3)
                desiredLane = 2;
        }

        if (SwipeManager.swipeLeft)
        {
            desiredLane--;
            if (desiredLane == -1)
                desiredLane = 0;
        }

        //Calculate where we should be in the future

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if(desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }else if(desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        transform.position = targetPosition;
        //transform.position = Vector3.Lerp(transform.position, targetPosition, 80 * Time.deltaTime );
        controller.center = controller.center;
    }
    private void FixedUpdate()
    {
        if (!PlayerManager.isGameStarted)
            return;
        controller.Move(direction * Time.fixedDeltaTime);
    }

    private void MoveLaneLeft()
    {
        desiredLane--;
        if (desiredLane < 0)
            desiredLane = 0;
    }

    private void MoveLaneRight()
    {
        desiredLane++;
        if (desiredLane > 2)
            desiredLane = 2;
    }
    private void Jump()
    {
        direction.y = jumpForce;
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag== "Obstacle")
        {
            PlayerManager.gameOver = true;
            FindAnyObjectByType<AudioManager>().PlaySound("GameOver");
        }
    }
}
