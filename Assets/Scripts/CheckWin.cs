using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
    [SerializeField] GetScore script;
    private void OnCollisionEnter(Collision other) 
    {
     if(other.gameObject.tag == "Player")
     {
         //If HitObjects < WinCondition
        GetComponent<MeshRenderer>().material.color = Color.green;
     }
    }
}
