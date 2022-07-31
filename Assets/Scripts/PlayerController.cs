using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 5f;
    [SerializeField]
    private float _gravity = -20f;
    [SerializeField]
    public float _rotationSpeed = 90;
    [SerializeField]
    public float _jumpSpeed = 15;

    private CharacterController _controller;
    Vector3 moveVelocity;
    Vector3 turnVelocity;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        direction.Normalize();

        if (_controller.isGrounded)
        {
            moveVelocity = transform.forward * _moveSpeed * verticalInput;
            turnVelocity = transform.up * _rotationSpeed * horizontalInput;

            if (Input.GetButtonDown("Jump"))
            {
                moveVelocity.y = _jumpSpeed;
            }
        }

        moveVelocity.y += _gravity * Time.deltaTime;
        _controller.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);

        //direction.y = -_gravity;

        //_controller.Move(direction * Time.deltaTime * _moveSpeed);
        //transform.Translate(direction * _moveSpeed * Time.deltaTime, Space.World);

        //if (direction != Vector3.zero)
        //{
        //    //transform.forward = direction;
        //    Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);

        //    transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, _rotationSpeed * Time.deltaTime);
        //}
    }
}
