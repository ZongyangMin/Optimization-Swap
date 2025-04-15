using UnityEngine;

public class Paddle_Computer : Paddle_Parent
{

    // Declare Variables
    public Rigidbody2D ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.ball.position.y > this.transform.position.y)
        {
            _rigidbody2D.AddForce(Vector2.up * this.speed);
        }
        else if(this.ball.position.y < this.transform.position.y)
        {
            _rigidbody2D.AddForce(Vector2.down * this.speed);
        }
        else
        {
            if(this.transform.position.y > 0.0f)
            {
                _rigidbody2D.AddForce(Vector2.down * this.speed);
            }
            else if(this.transform.position.y < 0.0f)
            {
                _rigidbody2D.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
