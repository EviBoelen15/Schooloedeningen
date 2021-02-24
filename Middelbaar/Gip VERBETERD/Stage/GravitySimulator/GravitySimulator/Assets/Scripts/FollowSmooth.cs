using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSmooth : MonoBehaviour
{

    // The target we are following
    [SerializeField]
    private Transform target;
    public float positionDamping;

    // Update is called once per frame
    void LateUpdate()
    {
        if (!target)
            return;

        //The player object tracks the movement of the chosen target (target.position) 
        //The player object follows this movement with a speed assigned as Damping (with delay)
        transform.position = Vector3.Lerp(transform.position, target.position, positionDamping * Time.deltaTime);

        //Makes the player object look at the chosen target and follow it smoothly
        var rotation = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * positionDamping);
        transform.rotation = Quaternion.Euler(0, transform.eulerAngles.y, 0 /*transform.eulerAngles.z*/);
    }
}
