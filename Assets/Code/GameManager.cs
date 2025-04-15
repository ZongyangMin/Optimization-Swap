using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    // Declare Variables
    private int _playerScore;

    public Paddle_Parent _player_Paddle;

    public Paddle_Parent _computer_Paddle;
    private int _computerScore;

    public Text _playerText;
    public Text _computerText;

    public Ball ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerScores()
    {
        _playerScore++;

        this._playerText.text = _playerScore.ToString();

        this._player_Paddle.ResetPosition();

        this.ball.ResetPosition();
    }

    public void ComputerScores()
    {
        _computerScore++;

        this._computerText.text = _computerScore.ToString();

        this._computer_Paddle.ResetPosition();

        this.ball.ResetPosition();
    }
}
