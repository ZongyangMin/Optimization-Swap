using UnityEngine;

public class Paddle_Parent : MonoBehaviour
{

    // Declare Variables
    public Rigidbody2D _rigidbody2D;

    public float speed = 10.0f;

    // When object is activated
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        _rigidbody2D.position = new Vector2(_rigidbody2D.position.x, 0.0f);
        _rigidbody2D.linearVelocity = Vector2.zero;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
