using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour {

    public GameObject portalCore;
    Animator anim;
    public static PortalController Instance;
    public int score;

    void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        portalCore.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (score >=3)
        {
            anim.SetBool("character_nearby", true);
            portalCore.SetActive(true);
        }
	}
}
