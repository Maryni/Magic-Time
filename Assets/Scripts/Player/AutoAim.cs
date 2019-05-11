using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class AutoAim : MonoBehaviour
{
    [SerializeField] GameObject me;
    Transform _me;
    [SerializeField] float radiusSphere;
    private void Start()
    {
        _me = me.transform;
    }
    private void Update()
    {
        
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(_me.transform.position, radiusSphere);
    }
    void CheckTrigger()
    {
        
    }
}
