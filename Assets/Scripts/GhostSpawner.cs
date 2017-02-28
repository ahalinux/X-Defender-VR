using UnityEngine;
using System.Collections;

public class GhostSpawner : MonoBehaviour {

    public float minTime = 2;
    public float meanTime = 1;
    public GameObject ghostSpawner;

    private float nextSpawnTime = 0;

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            Spawn();
            nextSpawnTime = Time.time + minTime - Mathf.Log(Random.value) * meanTime;
        }
    }

    void Spawn()
    {
        var instance = GameObject.Instantiate(ghostSpawner, this.transform.position, this.transform.rotation, this.transform);
    }
}
