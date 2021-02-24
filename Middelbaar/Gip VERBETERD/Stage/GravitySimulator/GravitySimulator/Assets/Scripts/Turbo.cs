using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbo : MonoBehaviour
{

    PlayerBehaviour playerBehaviour;
    public float extraGravity;
    public float extraMoveSpeed;

    private bool isRightTriggered;
    private bool isLeftTiggered;
    //playerBehaviourscript gets called
    private void Awake()
    {
        playerBehaviour = FindObjectOfType<PlayerBehaviour>();
    }
    //procedure returns boolean and the type of controller that has been triggered
    //if the controller that had been used is left, istriggerleft = true, same counts for right
    public void ControllerTriggered(bool isTriggered, ControllerType controllerType)
    {
        if (controllerType == ControllerType.Left){
            isLeftTiggered = isTriggered;
        }
        else if (controllerType == ControllerType.Right){
            isRightTriggered = isTriggered;
        }
    }
    private void Update()
    {
        //if controller trigger left and right are pressed --> 2 * extra speed forward (turbo)
        //if controller trigger left and right are pressed --> 2 * extra gravity (downward)
        if (isLeftTiggered && isRightTriggered)
        {
            playerBehaviour.extraGravity = extraGravity * 2;
            playerBehaviour.extraMoveSpeed = extraMoveSpeed * 2;
        }
        //if left OR right trigger is pressed --> extra speed forward (faster in 1 direction)
        //if left OR right trigger is pressed --> extra gravity (downward)
        else if (isLeftTiggered || isRightTriggered ){
            playerBehaviour.extraGravity = extraGravity;
            playerBehaviour.extraMoveSpeed = extraMoveSpeed;
        }
        else{
            //no extra speed or gravity
            playerBehaviour.extraGravity = 0;
            playerBehaviour.extraMoveSpeed = 0;
        }
    }
}