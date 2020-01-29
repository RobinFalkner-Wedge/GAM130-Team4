﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpMechanic : MonoBehaviour
{
    public bool canPick;
    public GameObject uiPick;

    // Use this for initialization
    void Start()
    {
        canPick = false;
        uiPick.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 3f))
        {
            Debug.DrawRay(transform.position, transform.forward * 3f, Color.red);

            if (hit.collider.GetComponent<PickedObject>() != null)
            {
                canPick = true;
                uiPick.SetActive(true);
                Debug.Log("Hit");
            }

            else
            {
                uiPick.SetActive(false);
                canPick = false;
            }

            if (Input.GetMouseButtonDown(0) && canPick == true)
            {
                hit.collider.GetComponent<PickedObject>().IsPickedUp = true;
                Destroy(hit.transform.gameObject);
                //Add something to the resources value when we have them added. I plan to use enums for different objects


            }

        }

    }
}
