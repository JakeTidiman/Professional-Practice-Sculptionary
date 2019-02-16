using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public List<Teams> theTeams = new List<Teams>();

    public int numberOfTeams;

    public int PlayingTeam;

    public string[] catagoryOne;
    public string[] catagoryTwo;
    public string[] catagoryThree;
    public string[] catagoryFour;

    

    public Text catagoryText;

    public enum Teams
    {
        teamOne,
        teamTwo,
        teamThree,
        teamFour
    }

    public Teams currentTeam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
