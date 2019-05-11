using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPoint : MonoBehaviour
{

    [SerializeField] GameObject cam;
    [SerializeField] GameObject targetLook;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUdate()
    {
        cam.transform.LookAt(targetLook.transform);
    }
}
