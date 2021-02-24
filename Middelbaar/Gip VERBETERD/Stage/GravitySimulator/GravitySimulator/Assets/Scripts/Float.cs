using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Float : MonoBehaviour
{
    public ControllerType controllerType;
    private SteamVR_TrackedObject trackedObj;
    private PlayerBehaviour playerBehaviour;
    private Turbo turbo;    

    public float moveValue;
    public float rotateValue;

    private SteamVR_Controller.Device Controller
    {
        get
        {
            return SteamVR_Controller.Input((int)trackedObj.index);
        }
    }

    private void Awake()
    {
        playerBehaviour = FindObjectOfType<PlayerBehaviour>();
        turbo = FindObjectOfType<Turbo>();
    }

    void Start()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();

    }
    // Update is called once per frame
    void FixedUpdate()
    {

        if (Controller.GetHairTrigger() || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            playerBehaviour.RotatePlayer(rotateValue);
            turbo.ControllerTriggered(true , controllerType);
        }
        else
        {
            turbo.ControllerTriggered(false, controllerType);
        }
    }
}