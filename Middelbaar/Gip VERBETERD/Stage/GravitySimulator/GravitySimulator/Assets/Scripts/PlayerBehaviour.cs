using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class PlayerBehaviour : MonoBehaviour
{
    public float gravity;
    public float rotateSpeed;
    public float moveSpeed;

    public int ringCount;

    public float extraGravity;
    public float extraMoveSpeed;

    public Vector3 moveDirection;
    public Transform cameraHead;

    public Animator planeAnim;
    public ParticleSystem playerWind;
    public ParticleSystem playerClouds;

    public bool isGrounded = false;
    public bool isEnded = false;
    public bool isClickedstart = false;

    public AudioSource powerup;

    //rotate
    public void RotatePlayer(float rotationValue)
    {
        transform.Rotate(Vector3.up, rotationValue, Space.World);
    }
    void FixedUpdate()
    {
        if (isEnded) return;

        moveDirection = Vector3.zero;
        if (isClickedstart == true)
        {
            if (!isGrounded)
            {
                moveDirection = Vector3.forward * GetMoveSpeed();
                moveDirection.y -= GetGravity();
                transform.Translate(moveDirection * Time.deltaTime, Space.Self);
                planeAnim.SetTrigger("Jumped");
                playerWind.Play();
                playerClouds.Play();
            }
            else
            {
                moveSpeed = 0;
                playerWind.Stop();
                playerClouds.Stop();
            }
        }

    }

    public float GetMoveSpeed()
    {
        return moveSpeed + extraMoveSpeed;
    }

    private float GetGravity()
    {
        return gravity + extraGravity;
    }
}