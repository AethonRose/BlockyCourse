using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    [SerializeField] float DropWaitTime = 10f;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > DropWaitTime)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
        
    }
}
