using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Bar playerBar;
    public Bar computerBar;

    public Text playerScoreText;
    public Text computerScoreText;

    private int _playerScore;
    private int _computerScore;

    public void PlayerScores(){
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        this.ResetRound();
    }

    public void ComputerScores(){
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        this.ResetRound();
    }

    private void ResetRound(){
        this.playerBar.ResetPosition();
        this.computerBar.ResetPosition();
        this.ball.ResetPosition();
        this.ball.startMessage.text = "Press space key to start round";
    }
}
