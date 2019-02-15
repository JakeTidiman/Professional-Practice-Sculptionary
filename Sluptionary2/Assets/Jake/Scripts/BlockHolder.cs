using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHolder : MonoBehaviour
{

    Color startColor;

    DestroyBlockManager theManager;

    // Start is called before the first frame update
    void Start()
    {
        startColor = GetComponent<Renderer>().material.color;

        theManager = FindObjectOfType<DestroyBlockManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeColour()
    {
        GetComponent<Renderer>().material.color = Color.blue;

    }

    public void RevertColour()
    {
        GetComponent<Renderer>().material.color = startColor;
    }

}
