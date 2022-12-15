using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

    public float doorOpenTime = 15f;
    public float doorCloseTime = 60f;
    public float tipTime = 10f;
    public GameObject toolTip;
    public Animator anim;

    IEnumerator DoorOpener()
    {
        yield return new WaitForSeconds(doorOpenTime);
        anim.SetBool("character_nearby", true);
        StartCoroutine(DoorCloser());
    }

	// Use this for initialization
	void Start () {
        StartCoroutine(DoorControll());
	}
    IEnumerator DoorCloser()
    {
        yield return new WaitForSeconds(doorCloseTime- tipTime);
        toolTip.SetActive(true);
        yield return new WaitForSeconds(tipTime);
        anim.SetBool("character_nearby", false);
        toolTip.SetActive(false);
        StartCoroutine(DoorOpener());
    }
    IEnumerator DoorControll()
    {
        GameObject[] leftEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        while (true)
        {
            yield return new WaitForSeconds(doorOpenTime);
            anim.SetBool("character_nearby", true);
            yield return new WaitForSeconds(doorCloseTime - tipTime);
            toolTip.SetActive(true);
            yield return new WaitForSeconds(tipTime);
            anim.SetBool("character_nearby", false);
            toolTip.SetActive(false);
            foreach(GameObject go in leftEnemies)
            {
                print(go.gameObject.name);
                if(go.activeInHierarchy)
                {
                    go.SetActive(false);
                }
                
            }

        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
