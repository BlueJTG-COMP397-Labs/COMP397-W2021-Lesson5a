using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneController : MonoBehaviour
{
    public Transform spawnPoint;
    
    private void OnTriggerEnter(Collider other)
    {
        //check if the object that triggers a collision is the player
        if (other.gameObject.CompareTag("Player"))
        {
            var controller = other.gameObject.GetComponent<CharacterController>();//get a reference to the player's CharacterController
            controller.enabled = false; //turn controller off
            other.gameObject.transform.position = spawnPoint.position; //movie player to spawnPoint
            controller.enabled = true;//turn controller on
        }
    }
}
