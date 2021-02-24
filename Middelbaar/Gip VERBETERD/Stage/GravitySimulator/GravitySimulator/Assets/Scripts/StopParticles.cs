using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopParticles : MonoBehaviour {


    PlayerBehaviour playerBehaviour;
    public GameObject particleWind;

    private void Start()
    {
        playerBehaviour = FindObjectOfType<PlayerBehaviour>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "RubberBoat")
        {
            particleWind.SetActive(false);
        }
    }
}
