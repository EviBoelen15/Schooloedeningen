using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    PlayerBehaviour playerBehaviour;

    public ParticleSystem ring1;
    public ParticleSystem ring2;

    // Use this for initialization
    void Start()
    {
        playerBehaviour = FindObjectOfType<PlayerBehaviour>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Player")
        {
            playerBehaviour.ringCount++;
            playerBehaviour.powerup.Play();
            ring1.Stop();
            ring2.Play();
        }
    } 
}

