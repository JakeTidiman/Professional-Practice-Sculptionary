using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    

    public GameObject currentWindow;

    public GameObject windowToOpen;

    public bool ifTeamSelect;

    

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
        if (windowToOpen != null)
        {
            windowToOpen.SetActive(true);
        }
        if (currentWindow != null)
        {
            currentWindow.SetActive(false);
        }

        if (ifTeamSelect)
        {

            switch (GM.theTeams.Count)
            {
                case 0:
                    GM.theTeams.Add(GM.currentTeam++);
                    break;
                case 1:
                    GM.theTeams.Add(GM.currentTeam++);
                    break;
                case 2:
                    GM.theTeams.Add(GM.currentTeam++);
                    break;
                case 3:
                    GM.theTeams.Add(GM.currentTeam++);
                    break;
            }

            
        }
    }
}
