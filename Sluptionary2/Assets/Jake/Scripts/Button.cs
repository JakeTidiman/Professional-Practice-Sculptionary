﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    

    public GameObject[] currentWindow;

    public GameObject[] windowToOpen;

    public bool ifTeamSelect;

    public bool catagorySelect;

    public bool ifStartRound;

    public bool ifWin;

    public bool ifContinueTimer;

    public enum Catagories
    {
        catagoryOne,
        catagoryTwo,
        catagoryThree,
        catagoryFour
    }

    public Catagories catagory;

    private GameManager GM;

    // Start is called before the first frame update
    void Start()
    {
        GM = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeCanvasWindow()
    {
        /*if (windowToOpen != null)
        {
            foreach (var item in windowToOpen)
            {
                item.SetActive(true);
            }
            
        }
        if (currentWindow != null)
        {
            foreach (var item in currentWindow)
            {
                item.SetActive(false);
            }
        }*/

        if (ifTeamSelect)
        {
            switch (GM.theTeams.Count)
            {
                case 0:
                    GM.theTeams.Add(GM.currentTeam++);
                    GM.numberOfTeams++;
                    break;
                case 1:
                    GM.theTeams.Add(GM.currentTeam++);
                    GM.numberOfTeams++;
                    break;
                case 2:
                    GM.theTeams.Add(GM.currentTeam++);
                    GM.numberOfTeams++;
                    break;
                case 3:
                    GM.theTeams.Add(GM.currentTeam++);
                    GM.numberOfTeams++;
                    break;
            }            
        }

        if (catagorySelect)
        {
            switch (catagory)
            {
                case Catagories.catagoryOne:
                    GM.catagoryText.text = GM.catagoryOne[Random.Range(0, GM.catagoryOne.Length)];
                    break;
                case Catagories.catagoryTwo:
                    GM.catagoryText.text = GM.catagoryTwo[Random.Range(0, GM.catagoryOne.Length)];
                    break;
                case Catagories.catagoryThree:
                    GM.catagoryText.text = GM.catagoryThree[Random.Range(0, GM.catagoryOne.Length)];
                    break;
                case Catagories.catagoryFour:
                    GM.catagoryText.text = GM.catagoryFour[Random.Range(0, GM.catagoryOne.Length)];
                    break;
                default:
                    break;
            }
        }

        if (ifStartRound)
        {
            GM.currentTeam = GM.restartTeams;
            GM.scoreTimer = GM.resetScoreTimer; 
        }
        if (ifWin)
        {
            GM.PlayRound();
            GM.restartTeams++;
        }
        if (ifContinueTimer)
        {
            Time.timeScale = 1;
        }

    }


    
}
