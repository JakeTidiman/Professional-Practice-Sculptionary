using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlockManager : MonoBehaviour
{
    private GameObject destroyTarget;

    private Material hitMat;

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
            RaycastHit hit;

            if (Physics.Raycast(ray,out hit, 100))
            {
                print(hit.collider.name);
                destroyTarget = hit.collider.gameObject;
                hitMat = hit.collider.gameObject.GetComponent<Material>();
                hitMat.color = new Color(0, 215, 255);
            }               
        }

        if (Input.GetButtonUp("Fire1"))
        {
            Destroy(destroyTarget);
        }
    }
}
