using UnityEngine;

public class Paddle_Player : Paddle_Parent
{

    // Declare Variables
    private Vector2 _direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input Code
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }

        // Physics Engine Code
        if(_direction.sqrMagnitude != 0)
        {
            _rigidbody2D.AddForce(_direction * speed);
        }
    }

}
