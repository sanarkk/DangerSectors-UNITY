using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject[] spawnPoints;
    public int mobsToSpawn = 100;
    public float spawnDelay = 2f;
    public float timeForDoorOpening = 30f;
  
    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnWave());
    }
	
	// Update is called once per frame
	void Update () {
       
	}

    IEnumerator SpawnWave()
    {
        yield return new WaitForSeconds(timeForDoorOpening);
        for (int i = 0; i < mobsToSpawn; i++)
        {
            yield return new WaitForSeconds(spawnDelay);
            ObjectPool.Instance.SpawnFromPool("Enemy", spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, Quaternion.identity.normalized);
            //print("Object SPawned")
        }
       
    }
}
