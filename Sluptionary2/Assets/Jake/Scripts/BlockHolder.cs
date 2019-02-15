using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHolder : MonoBehaviour
{

    DestroyBlockManager theManager;

    // Start is called before the first frame update
    void Start()
    {
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

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.GetComponent<DestroyBlockManager>().hit.collider)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
