using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRound : MonoBehaviour
{

    private GameManager GM;

    // Start is called before the first frame update
    void Start()
    {
        GM = FindObjectOfType<GameManager>();
        GM.scoreTimer = GM.resetScoreTimer;
    }

    // Update is called once per frame
    void Update()
    {
        GM.CalculateScore();
    }
}
