using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject target;
    public float xOfset, yOfset, zOfset;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + new Vector3(xOfset, yOfset, zOfset);
        transform.LookAt(target.transform.position);
        
    }
}
