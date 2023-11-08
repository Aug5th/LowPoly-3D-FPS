using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MyMonoBehaviour
{
    private CharacterController _controller;
    private Vector3 _playerVelocity;
    private bool _grounded;
    private bool _sprinting;
    private bool _crouching;
    private bool _lerpCrouch;
    private float _crouchTimer;

    [SerializeField] private float gravity = -9.8f;
    [SerializeField] private float jumpHeight = 0.8f;
    [SerializeField] private float speed;
    [SerializeField] private float walkSpeed = 4f;
    [SerializeField] private float sprintSpeed = 6f;
    [SerializeField] private float crouchSpeed = 2f;
    private void Start()
    {
        speed = walkSpeed;
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        _grounded = _controller.isGrounded;
        Crouching();
    }
    public void Move(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        _controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        _playerVelocity.y += gravity * Time.deltaTime;
        if(_grounded && _playerVelocity.y < 0 )
        {
            _playerVelocity.y = -2f;
        }
        _controller.Move(_playerVelocity * Time.deltaTime);
    }

    public void Jump()
    {
        if(_grounded)
        {
            _playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }
    }

    public void Sprint()
    {
        _sprinting = !_sprinting;
        if(_sprinting)
        {
            speed = sprintSpeed;
        }
        else
        {
            speed = walkSpeed;
        }
    }

    public void Crouch()
    {
        _crouching = !_crouching;
        if(_crouching)
        {
            speed = crouchSpeed;
        }
        else
        {
            speed = walkSpeed;
        }
        _crouchTimer = 0;
        _lerpCrouch = true;
    }

    private void Crouching()
    {
        if (_lerpCrouch)
        {
            _crouchTimer += Time.deltaTime;
            float p = _crouchTimer / 1;
            p *= p;
            if (_crouching)
            {
                _controller.height = Mathf.Lerp(_controller.height, 1, p);
            }
            else
            {
                _controller.height = Mathf.Lerp(_controller.height, 2, p);
            }

            if (p > 1)
            {
                _lerpCrouch = false;
                _crouchTimer = 0f;
            }
        }
    }
}
