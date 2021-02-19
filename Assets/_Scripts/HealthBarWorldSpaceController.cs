using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarWorldSpaceController : MonoBehaviour
{
    public Transform playerCamera;

    private void Start()
    {
        playerCamera = GameObject.Find("PlayerCam").transform;
    }

    void LateUpdate()
    {
        //billboard the healthBar
        transform.LookAt(transform.position + playerCamera.forward);
    }


}
