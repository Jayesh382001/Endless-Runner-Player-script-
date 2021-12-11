using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController _controller;
    [SerializeField]
    private float _speed = 5.0f;
    [SerializeField]
    private float _jumpHeight = 10.0f;
    [SerializeField]
    private float _gravity = 1.0f;
    private float _yvelocity = 0.0f;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        Vector3 direction = Vector3.forward;
        Vector3 velocity = direction * _speed;
        if (_controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _yvelocity = _jumpHeight;
            }
            
        }
        else
        {
            _yvelocity -= _gravity;
        }
        velocity.y = _yvelocity;
        _controller.Move(velocity * Time.deltaTime);
    }
}
