using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public List<Teams> theTeams = new List<Teams>();

    public int numberOfTeams;

    public int playingTeam;

    public int cureentRound;

    public string[] catagoryOne;
    public string[] catagoryTwo;
    public string[] catagoryThree;
    public string[] catagoryFour;

    public int score1;
    public int score2;
    public int score3;
    public int score4;

    public Text score1Text;
    public Text score2Text;
    public Text score3Text;
    public Text score4Text;

    public Text winningScoreText;

    public Text catagoryText;
    public Text timerText;

    public GameObject retryButton;

    public float scoreTimer;
    public float resetScoreTimer;
    public float[] scoreBreakPoints;

    public enum Teams
    {
        teamOne,
        teamTwo,
        teamThree,
        teamFour
    }

    public Teams currentTeam;
    public Teams restartTeams;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayRound()
    {
        print(currentTeam);
        switch (currentTeam)
        {
            case Teams.teamOne:
                //CalculateScore();
                score1 += Mathf.RoundToInt(scoreTimer) / 2;
               // playingTeam = 0;
                break;
            case Teams.teamTwo:
               // CalculateScore();
                score2 += Mathf.RoundToInt(scoreTimer) / 2;
               // playingTeam = 1;
                break;
            case Teams.teamThree:
                //CalculateScore();
                score3 += Mathf.RoundToInt(scoreTimer) / 2;
               // playingTeam = 2;
                break;
            case Teams.teamFour:
                //CalculateScore();
                score4 += Mathf.RoundToInt(scoreTimer) / 2;
               // playingTeam = 3;
                break;
        }

        if (playingTeam == numberOfTeams)
        {
            cureentRound++;
            currentTeam = Teams.teamOne;
            playingTeam = 0;
            restartTeams = 0;
        }
        else
        {
            restartTeams++;
        }
        if (cureentRound == 2)
        {
            winningScoreText.text = Mathf.Max(score1, score2, score3, score4).ToString();
        }

        score1Text.text = "Team One: " + score1.ToString();
        score2Text.text = "Team Two: " + score2.ToString();
        score3Text.text = "Team Three: " + score3.ToString();
        score4Text.text = "Team Four: " + score4.ToString();
    }

    public void CalculateScore()
    {
        scoreTimer -= Time.deltaTime;
        timerText.text = scoreTimer.ToString();

        foreach (var item in scoreBreakPoints)
        {
            if (scoreTimer == item)
            {
                retryButton.SetActive(true);
                Time.timeScale = 0;
            }
        }

    }

    public void EndOfRound()
    {
        if (playingTeam == numberOfTeams)
        {
            cureentRound++;
            currentTeam = Teams.teamOne;
            playingTeam = 0;
            restartTeams = 0;
        }
        else
        {
            restartTeams++;
        }
        if (cureentRound == 2)
        {
            winningScoreText.text = Mathf.Max(score1, score2, score3, score4).ToString();
        }
    }

}
