using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaderboard : MonoBehaviour
{

    private GameManager GM;

    public GameObject[] leaderboardText;

    // Start is called before the first frame update
    void Start()
    {
        GM = FindObjectOfType<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowTeams();
    }

    void ShowTeams()
    {
        switch (GM.numberOfTeams)
        {
            case 1:
                leaderboardText[0].SetActive(true);
                break;
            case 2:
                leaderboardText[0].SetActive(true);
                leaderboardText[1].SetActive(true);
                break;
            case 3:
                leaderboardText[0].SetActive(true);
                leaderboardText[1].SetActive(true);
                leaderboardText[2].SetActive(true);
                break;
            case 4:
                leaderboardText[0].SetActive(true); 
                leaderboardText[1].SetActive(true);
                leaderboardText[2].SetActive(true);
                leaderboardText[3].SetActive(true);
                break;
        }
    }


}
