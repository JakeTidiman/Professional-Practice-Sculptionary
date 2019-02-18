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
                if (hit.collider.gameObject != hitBlocks.Contains(hit.collider.gameObject))
                {
                    hitBlocks.Add(hit.collider.gameObject);
                }
                
               
                destroyTarget = hit.collider.gameObject;

                destroyTarget.GetComponent<BlockHolder>().ChangeColour();              
            } 

        }

        if (Input.GetButtonUp("Fire1"))
        {
            StartCoroutine(DoColorRevert());
            Destroy(destroyTarget);
        }
    }

    IEnumerator DoColorRevert()
    {
        for (int i = 0; i < hitBlocks.Count; i++)
        {
            hitBlocks[i].GetComponent<BlockHolder>().RevertColour();
            //hitBlocks.Remove(hitBlocks[i]);
            hitBlocks[i] = null;
        }
        yield return new WaitForSeconds(0.2f);
        hitBlocks = new List<GameObject>();
    }

}
