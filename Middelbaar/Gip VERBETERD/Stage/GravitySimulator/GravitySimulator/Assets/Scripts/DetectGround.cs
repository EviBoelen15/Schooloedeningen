using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectGround : MonoBehaviour
{

    PlayerBehaviour playerBehaviour;
    public float distanceToground = 0.5f;
    public string DontMoveOn, stopMoving;

    public EndPanel endPanel;
    public DeadPanel deadPanel;


    private void Awake()
    {
        playerBehaviour = FindObjectOfType<PlayerBehaviour>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //declaration raycast (detects if there is a collision)
        RaycastHit hit;

        //The raycast starts at the position of the player object
        //The raycast casts a ray downwards and calculates if there has been a collision
        //The raycast sends a value out to that is true when there is a collision and false when there is not
        if (Physics.Raycast(transform.position, Vector3.down, out hit, distanceToground))
        {
            Debug.Log(hit.transform.gameObject);
            //if the gameobject with the tag "Ground" of "RubberBoeat is hit, it returns that the player is on the ground
            // player stops moving 
            if (hit.transform.gameObject.tag == "Plane")
            {
                playerBehaviour.isGrounded = true;
                playerBehaviour.moveSpeed = 0;
                //transform.Translate(new Vector3(0, 0, 0));
            }
            else if (hit.transform.gameObject.tag == "RubberBoat")
            {
                playerBehaviour.isGrounded = true;
                playerBehaviour.isEnded = true;
                endPanel.Show();
                endPanel.RingText();
            }
            else if (hit.transform.gameObject.tag == "Water" || hit.transform.gameObject.tag == "Envoirement")
            {
                playerBehaviour.isGrounded = true;
                playerBehaviour.gravity = 0;
                deadPanel.Show();
            }
            //else it returns that the player is not on the ground
            else
            {
                playerBehaviour.isGrounded = false;
                playerBehaviour.moveSpeed = 3;
            }
        }
        else
        {
            playerBehaviour.isGrounded = false;
            playerBehaviour.moveSpeed = 3;
        }
    }
}