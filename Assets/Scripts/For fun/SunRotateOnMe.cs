using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotateOnMe : MonoBehaviour
{
    [SerializeField] GameObject sun;
    [SerializeField] Transform _sun;
    void Start()
    {
        _sun = sun.transform;
    }

    void FixedUpdate()
    {
        
    }
}
