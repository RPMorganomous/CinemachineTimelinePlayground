using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerHowTo : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 5f;  // how fast our player will move
    [SerializeField]
    private float _gravity = -20f;  // how strong is gravity when we jump
    [SerializeField]
    private float _roatationSpeed = 90f;  // how quickly our player will turn
    [SerializeField]
    private float _jumpSpeed = 15f;  // how fast our player will jump

    private float horizontalInput;  // our horizontal axis (forward/backward - Z axis)
    private float verticalInput;  // our vertical axis (left/right - X axis)


    Vector3 moveVelocity; // forward velocity
    Vector3 turnVelocity; // rotate velocity
    Vector3 direction; // the direction we will go

    private CharacterController _controller; // variable of type CharacterController

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>(); // assign the CharacterController to a variable
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); // W & S key
        verticalInput = Input.GetAxis("Vertical"); // A & D key

        direction = new Vector3(horizontalInput, 0, verticalInput); // use WSAD keys for directional values
        direction.Normalize(); // set vector magnitude to 1.0

        if (_controller.isGrounded) { // must be on a surface to jump so no double-jumping and no movement changes while airborne but make sure Min Move Distance on the CharacterController is set to 0

            moveVelocity = transform.forward * _moveSpeed * verticalInput; // forward/backward - Z axis
            turnVelocity = transform.up * _roatationSpeed * horizontalInput; // rotate direction - X axis

            if (Input.GetKeyDown(KeyCode.Space)) // space bar
            {
                moveVelocity.y = _jumpSpeed; // set upward velocity burst
            }

        }
        moveVelocity.y += _gravity * Time.deltaTime; // account for gravity

        _controller.Move(moveVelocity * Time.deltaTime); // move the player regulated by constant time
        transform.Rotate(turnVelocity * Time.deltaTime); // turn the player regulated by constant time

    }
}
