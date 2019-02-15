using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public List<Teams> theTeams = new List<Teams>();

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
