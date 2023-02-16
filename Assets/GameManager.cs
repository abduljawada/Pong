using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float playerSpeed = 3f;
    public float ballSpeed = 5f;
    public int player1Score = 0;
    public int player2Score = 0;
    public static GameManager gameManager;
    public Player player1;
    public Player player2;
    public Ball ball;
    public TMP_Text player1ScoreText;
    public TMP_Text player2ScoreText;

    private void Awake()
    {
        gameManager = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScore(bool isPlayer1Scored)
    {
        if (isPlayer1Scored)
        {
            player1Score++;
            player1ScoreText.text = player1Score.ToString();
        }
        else
        {
            player2Score++;
            player2ScoreText.text = player2Score.ToString();
        }
        player1.ResetPos();
        player2.ResetPos();
        ball.ResetPos(isPlayer1Scored);
    }


}
