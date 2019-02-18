using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBlocks : MonoBehaviour
{
    public GameObject blocks;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(blocks, transform.position + transform.TransformDirection(Vector3.up * 15), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
