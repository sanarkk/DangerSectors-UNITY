using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickup : MonoBehaviour {

    public bool canPickup = true;
    public GameObject playerGun;
    public GameObject toolTip;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && canPickup)
        {
            toolTip.SetActive(true);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && other.CompareTag("Player") && canPickup)
        {
            playerGun.SetActive(true);
            toolTip.SetActive(false);
            canPickup = false;
            this.gameObject.SetActive(false);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && canPickup)
        {
            toolTip.SetActive(false);
        }
    }
}
