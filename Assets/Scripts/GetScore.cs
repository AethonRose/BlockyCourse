using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    [SerializeField] int ObjectsCollidedWith = 0;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Obstacle")
        {
            ObjectsCollidedWith++;
            Debug.Log("You have walked into " + ObjectsCollidedWith + " Objects");
        }
        
    }
}
