using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PickupThrow : MonoBehaviour
{
    [SerializeField] private GameObject hand_point;

    private GameObject picked_object = null;
    
    
    // Update is called once per frame
    void Update()
    {
        if (picked_object != null)
        {
            if (Input.GetKey("r") || Input.GetButtonDown("Fire1"))
            {
                picked_object.GetComponent<Rigidbody>().useGravity = true;
                picked_object.GetComponent<Rigidbody>().isKinematic = false;
                picked_object.gameObject.transform.SetParent(null);
                picked_object = null;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Papers") || other.gameObject.CompareTag("Glasses") ||
            other.gameObject.CompareTag("Organics") || other.gameObject.CompareTag("Plastics"))
        {
            if ((Input.GetKey("e") || Input.GetButtonDown("Fire3")) && picked_object == null)
            {
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = hand_point.transform.position;
                other.gameObject.transform.SetParent(hand_point.gameObject.transform);
                picked_object = other.gameObject;
            }
        }
    }
}