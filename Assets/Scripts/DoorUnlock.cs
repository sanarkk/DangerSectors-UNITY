using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUnlock : MonoBehaviour {

    public bool canOpen = true;
    public Animator doorAnim;
    public GameObject toolTip;

	void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player") && canOpen)
        {
            toolTip.SetActive(true);
        }	
	}
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && other.CompareTag("Player") && canOpen)
        {
            doorAnim.SetBool("character_nearby", true);
            toolTip.SetActive(false);
            canOpen = false;

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && canOpen)
        {
            toolTip.SetActive(false);
        }      
    }
}
