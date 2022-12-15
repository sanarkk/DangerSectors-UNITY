using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoTrebaRobyty : MonoBehaviour
{

    public GameObject toolTip;


    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            toolTip.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            toolTip.SetActive(false);
        }
    }
}
