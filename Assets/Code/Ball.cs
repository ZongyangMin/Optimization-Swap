using UnityEngine;

public class Ball : MonoBehaviour
{

    // Declare Variable
    Rigidbody2D _rigidbody2D;

    public float speed = 200.0f;

    // When Object is Activated
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AddStartingForce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Random Angle and Speed of Starting Ball
    void AddStartingForce()
    {
        // Get Random Chance for Start
        float x = Random.Range(0.0f,10.0f) / 10.0f;
        float start = x < 0.5? -1.0f : 1.0f;
        float y = x < 0.5? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f,1.0f);

        Vector2 direction = new Vector2(start, y);
        _rigidbody2D.AddForce(direction * this.speed);

    }

    public void AddForce(Vector2 force)
    {
        _rigidbody2D.AddForce(force);
    }

    public void ResetPosition()
    {
        _rigidbody2D.position = Vector3.zero;
        _rigidbody2D.linearVelocity = Vector3.zero;

        AddStartingForce();
    }
}
