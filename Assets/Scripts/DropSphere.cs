using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSphere : MonoBehaviour
{

    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    [SerializeField] float DropWaitTime = 3f;

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
