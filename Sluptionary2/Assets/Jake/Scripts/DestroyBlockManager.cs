using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlockManager : MonoBehaviour
{
    private GameObject destroyTarget;
    private GameObject currentMarker;
     
    public List<GameObject> hitBlocks = new List<GameObject>();

    
    public RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DoRaycast();
    }

    void DoRaycast()
    {
        if (Input.GetButton("Fire1"))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out hit, 100))
            {
                hitBlocks.Add(hit.collider.gameObject);

                print(hit.collider.name);
                destroyTarget = hit.collider.gameObject;

                hit.collider.GetComponent<BlockHolder>().ChangeColour();
            } 

        }

        if (Input.GetButtonUp("Fire1"))
        {
            Destroy(destroyTarget);
        }
    }
}
