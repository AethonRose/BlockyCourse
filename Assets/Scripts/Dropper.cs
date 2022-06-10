using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    [SerializeField] float DropWaitTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > DropWaitTime){
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
        
    }
}